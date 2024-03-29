﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript
{
    /// <summary>
    /// 调用方法
    /// </summary>
    public class StatementChainStep : Step
    {
        /// <summary>
        /// ${Target}.MethodA().MethodB();
        /// </summary>
        public string Target { get; set; }

        /// <summary>
        /// 调用方法表达式
        /// </summary>
        public List<CallMethodExpression> CallMethodExpressions { get; set; }
    }

    /// <summary>
    /// StatementChainStepBuilderExtension
    /// </summary>
    public static class StatementChainStepBuilderExtension
    {
        /// <summary>
        /// 添加一个方法表达式
        /// </summary>
        public static TCallMethodStepBuilder SetTarget<TCallMethodStepBuilder>(this TCallMethodStepBuilder callMethodStepBuilder, string target)
            where TCallMethodStepBuilder : StatementChainStep
        {
            callMethodStepBuilder.Target = target;

            return callMethodStepBuilder;
        }
        /// <summary>
        /// 添加一个方法表达式
        /// </summary>
        public static TCallMethodStepBuilder AddCallMethodExpression<TCallMethodStepBuilder>(this TCallMethodStepBuilder callMethodStepBuilder, CallMethodExpression callMethodExpression)
            where TCallMethodStepBuilder : StatementChainStep
        {
            if (callMethodStepBuilder.CallMethodExpressions == null)
            {
                callMethodStepBuilder.CallMethodExpressions = new List<CallMethodExpression>();
            }

            callMethodStepBuilder.CallMethodExpressions.Add(callMethodExpression);

            return callMethodStepBuilder;
        }

        /// <summary>
        /// 添加一个方法表达式
        /// </summary>
        public static CallMethodExpression AddCallMethodExpression<TCallMethodStepBuilder>(this TCallMethodStepBuilder callMethodStepBuilder, string methodName)
            where TCallMethodStepBuilder : StatementChainStep
        {
            if (callMethodStepBuilder.CallMethodExpressions == null)
            {
                callMethodStepBuilder.CallMethodExpressions = new List<CallMethodExpression>();
            }

            CallMethodExpression callMethodExpression = new CallMethodExpression();
            callMethodExpression.MethodName = methodName;

            callMethodStepBuilder.CallMethodExpressions.Add(callMethodExpression);

            return callMethodExpression;
        }

        /// <summary>
        /// 添加一批方法表达式
        /// </summary>
        public static TCallMethodStepBuilder AddCallMethodExpressions<TCallMethodStepBuilder>(this TCallMethodStepBuilder callMethodStepBuilder, List<CallMethodExpression> callMethodExpressions)
            where TCallMethodStepBuilder : StatementChainStep
        {
            if (callMethodExpressions == null || callMethodExpressions.Count == 0)
            {
                return callMethodStepBuilder;
            }
            if (callMethodStepBuilder.CallMethodExpressions == null)
            {
                callMethodStepBuilder.CallMethodExpressions = new List<CallMethodExpression>();
            }

            callMethodStepBuilder.CallMethodExpressions.AddRange(callMethodExpressions);

            return callMethodStepBuilder;
        }
    }
}
