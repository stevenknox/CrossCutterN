﻿/**
* Description: Write only weaving plan
* Author: David Cui
*/

namespace CrossCutterN.Weaver.Batch
{
    using System.Reflection;
    using Aspect;
    using Advice.Common;

    internal interface ICanAddJoinPoint : ICanConvertToReadOnly<IWeavingPlan>
    {
        void AddJoinPoint(JoinPoint joinPoint, string builderId, MethodInfo advice, int sequence, AdviceParameterFlag flag);
    }
}