﻿using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverseCurveSidebarBot
{
    [Function("fee", "uint256")]
    public class GetFeeFunction : FunctionMessage
    {
    }
}
