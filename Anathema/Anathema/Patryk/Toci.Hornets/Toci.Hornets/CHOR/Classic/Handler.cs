﻿namespace Toci.Hornets.CHOR.Classic
{
    public abstract class Handler
    {
        protected Handler Successor;

        public void SetSuccessor(Handler successor)
        {
            Successor = successor;
        }

        public abstract void HandleRequest(Mobile mobile);
    }
}