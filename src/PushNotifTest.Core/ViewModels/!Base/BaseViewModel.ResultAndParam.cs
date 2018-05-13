﻿using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PushNotifTest.Core.ViewModels
{
    public abstract class BaseViewModel<TParameter, TResult> : BaseViewModelResult<TResult>, IMvxViewModel<TParameter, TResult>
    {
        public abstract void Prepare(TParameter parameter);
    }
}
