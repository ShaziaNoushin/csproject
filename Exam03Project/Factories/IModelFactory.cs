﻿using Exam03Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam03Project.Factories
{
    public interface IModelFactory
    {
        T Create<T>(params object[] args) where T : class, IModelBase, new();
    }
}
