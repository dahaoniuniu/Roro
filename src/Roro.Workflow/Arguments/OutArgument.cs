﻿using Roro.Activities;

namespace Roro.Workflow
{
    public class OutArgument : Argument
    {
        public override ArgumentDirection Direction => ArgumentDirection.Out;

        public override Argument ToNonGeneric()
        {
            return new OutArgument()
            {
                Name = Name,
                ArgumentType = ArgumentType,
                Expression = Expression
            };
        }
    }

    public class OutArgument<T> : OutArgument, Output<T>
    {
        T Output<T>.RuntimeValue
        {
            set => base.RuntimeValue = value;
        }
    }
}