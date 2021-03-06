<?php

	class CrudGenerator
	{
		const MODEL_TYPE = 'ModelType';
		
		public function GenerateForm(IDbModel $model)
		{
			$fields = $model->GetFields();
			
			$result = '<form method="POST" action="'.$_SERVER['PHP_SELF'].'"><div>';
			$result .= Controls::AddHidden(self::MODEL_TYPE, get_class($model));
			
			foreach ($fields as $fieldKey => $field)
			{
				if (!$field->IsAutomatic())
				{
					$result .= '<div>'.Controls::AddTextBox($field->GetFieldName(), $field->GetFieldName(), $field->GetValue()).'</div>';
				}
			}
			
			$result .= '</div>';
			$result .= Controls::AddSubmitButton('zatwierd�', 'confirm');
			$result .= '</form>';
			
			return $result;
		}
		
		public function SaveData()
		{
			if ($_SERVER['REQUEST_METHOD'] == "POST")
			{
				$model = new $_POST[self::MODEL_TYPE];
				
				//var_dump($model);
				
				foreach ($_POST as $key => $value)
				{
					if ($model->HasField($key))
					{
						$model->Set($key, $value);
					}
				}
				
				$insert = new PostgreSqlInsert();
	
				$handle = new PostgreSqlDbHandle();
				
				$insertCommand = $insert->Insert($model);
				
				//var_dump($insertCommand);
				
				$handle->Connect();
				$handle->RunQuery($insertCommand);
			}
		}
	}