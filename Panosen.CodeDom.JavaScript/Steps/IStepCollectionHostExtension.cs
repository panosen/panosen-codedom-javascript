﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript
{
    /// <summary>
    /// IStepCollectionHost 扩展
    /// </summary>
    public static class IStepCollectionHostExtension
    {
        /// <summary>
        /// 添加一个步骤
        /// </summary>
        public static TStepCollectionHost AddStep<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost, Step stepBuilder)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            StepCollectionExtension.AddStep(stepBuilderCollectionHost.StepCollection, stepBuilder);

            return stepBuilderCollectionHost;
        }

        /// <summary>
        /// 添加一个步骤
        /// </summary>
        public static TStepCollectionHost AddStep<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost, string name, Step stepBuilder)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            StepCollectionExtension.AddStep(stepBuilderCollectionHost.StepCollection, name, stepBuilder);

            return stepBuilderCollectionHost;
        }

        /// <summary>
        /// 添加一个步骤集合
        /// </summary>
        public static TStepCollectionHost AddStepCollection<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost, StepCollection stepBuilder)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            StepCollectionExtension.AddStepCollection(stepBuilderCollectionHost.StepCollection, stepBuilder);

            return stepBuilderCollectionHost;
        }

        /// <summary>
        /// 添加一个步骤集合
        /// </summary>
        public static TStepCollectionHost AddStepCollection<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost, string name, StepCollection stepBuilder)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            StepCollectionExtension.AddStepCollection(stepBuilderCollectionHost.StepCollection, name, stepBuilder);

            return stepBuilderCollectionHost;
        }

        /// <summary>
        /// 添加一个步骤集合
        /// </summary>
        public static StepCollection AddStepCollection<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            StepCollection stepBuilder = new StepCollection();

            StepCollectionExtension.AddStepCollection(stepBuilderCollectionHost.StepCollection, stepBuilder);

            return stepBuilder;
        }

        /// <summary>
        /// 添加一个步骤集合
        /// </summary>
        public static StepCollection AddStepCollection<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost, string name)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            StepCollection stepBuilder = new StepCollection();

            StepCollectionExtension.AddStepCollection(stepBuilderCollectionHost.StepCollection, name, stepBuilder);

            return stepBuilder;
        }

        /// <summary>
        /// 添加一个空行
        /// </summary>
        public static TStepCollectionHost StepEmpty<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            StepCollectionExtension.StepEmpty(stepBuilderCollectionHost.StepCollection);

            return stepBuilderCollectionHost;

        }

        /// <summary>
        /// 添加一个步骤
        /// </summary>
        public static TStepCollectionHost StepStatement<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost, string statement)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            StepCollectionExtension.StepStatement(stepBuilderCollectionHost.StepCollection, statement);

            return stepBuilderCollectionHost;
        }

        ///////// <summary>
        ///////// 添加一个 using 块
        ///////// </summary>
        //////public static UsingStep StepUsing<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost, string content = null)
        //////    where TStepCollectionHost : IStepCollectionHost
        //////{
        //////    stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

        //////    return StepCollectionExtension.StepUsing(stepBuilderCollectionHost.StepCollection, content);
        //////}

        /// <summary>
        /// 添加一个 if 块
        /// </summary>
        public static IfStep StepIf<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost, string condition = null)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            return StepCollectionExtension.StepIf(stepBuilderCollectionHost.StepCollection, condition);
        }

        /// <summary>
        /// 添加一个 if 块
        /// </summary>
        public static WhileStep StepWhile<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost, string condition = null)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            return StepCollectionExtension.StepWhile(stepBuilderCollectionHost.StepCollection, condition);
        }

        /// <summary>
        /// switch语句块
        /// </summary>
        public static SwitchStep StepSwitch<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost, string expression = null)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            return StepCollectionExtension.StepSwitch(stepBuilderCollectionHost.StepCollection, expression);
        }

        ///////// <summary>
        ///////// 添加一个 try 块
        ///////// </summary>
        //////public static TryStep StepTry<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost)
        //////    where TStepCollectionHost : IStepCollectionHost
        //////{
        //////    stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

        //////    return StepCollectionExtension.StepTry(stepBuilderCollectionHost.StepCollection);
        //////}

        ///////// <summary>
        ///////// 添加一个 foreach 块
        ///////// </summary>
        //////public static ForeachStep StepForeach<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost, string item, string items)
        //////    where TStepCollectionHost : IStepCollectionHost
        //////{
        //////    stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

        //////    return StepCollectionExtension.StepForeach(stepBuilderCollectionHost.StepCollection, item, items);
        //////}

        ///////// <summary>
        ///////// 添加一个 foreach 块
        ///////// </summary>
        //////public static ForeachStep StepForeach<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost, string type, string item, string items)
        //////    where TStepCollectionHost : IStepCollectionHost
        //////{
        //////    stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

        //////    return StepCollectionExtension.StepForeach(stepBuilderCollectionHost.StepCollection, type, item, items);
        //////}

        /// <summary>
        /// 添加一个 for 块
        /// </summary>
        public static ForStep StepFor<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost, string start, string middle, string end)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            return StepCollectionExtension.StepFor(stepBuilderCollectionHost.StepCollection, start, middle, end);
        }

        /// <summary>
        /// 添加一个代码块
        /// </summary>
        public static BlockStep StepBlock<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            return StepCollectionExtension.StepBlock(stepBuilderCollectionHost.StepCollection);
        }

        /// <summary>
        /// 添加一个缩进块
        /// </summary>
        public static PushIndentStep StepPushIndent<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost, string key)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            return StepCollectionExtension.StepPushIndent(stepBuilderCollectionHost.StepCollection, key);
        }

        /// <summary>
        /// 调用方法
        /// </summary>
        public static StatementChainStep StepStatementChain<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost, string target = null)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            return StepCollectionExtension.StepStatementChain(stepBuilderCollectionHost.StepCollection, target);
        }

        ///////// <summary>
        ///////// 为变量赋值
        ///////// </summary>
        //////public static AssignmentStep StepAssignment<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost)
        //////    where TStepCollectionHost : IStepCollectionHost
        //////{
        //////    stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

        //////    return StepCollectionExtension.StepAssignment(stepBuilderCollectionHost.StepCollection);
        //////}











        /// <summary>
        /// 返回DataObject
        /// </summary>
        public static ReturnDataObjectStep StepReturnDataObject<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            return StepCollectionExtension.StepReturnDataObject(stepBuilderCollectionHost.StepCollection);
        }

        /// <summary>
        /// 返回SortedDataObject
        /// </summary>
        public static ReturnSortedDataObjectStep StepReturnSortedDataObject<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            return StepCollectionExtension.StepReturnSortedDataObject(stepBuilderCollectionHost.StepCollection);
        }

        /// <summary>
        /// 在当前步骤定义方法
        /// function add() { }
        /// </summary>
        public static TStepCollectionHost StepDefineMethod<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost, CodeMethod codeMethod)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            StepCollectionExtension.StepDefineMethod(stepBuilderCollectionHost.StepCollection, codeMethod);

            return stepBuilderCollectionHost;
        }

        /// <summary>
        /// 在当前步骤将方法赋值给指定变量
        /// name = function () { }
        /// </summary>
        public static CodeMethod StepAssignMethod<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost, string name)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            return StepCollectionExtension.StepAssignMethod(stepBuilderCollectionHost.StepCollection, name);
        }

        /// <summary>
        /// 在当前步骤将方法赋值给指定变量
        /// name = function () { }
        /// </summary>
        public static TStepCollectionHost StepAssignMethod<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost, string name, CodeMethod codeMethod)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            StepCollectionExtension.StepAssignMethod(stepBuilderCollectionHost.StepCollection, name, codeMethod);

            return stepBuilderCollectionHost;
        }

        /// <summary>
        /// 赋值一个 DataObject
        /// </summary>
        public static AssignDataObjectStep StepAssignDataObject<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost, string name)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            return StepCollectionExtension.StepAssignDataObject(stepBuilderCollectionHost.StepCollection, name);
        }

        /// <summary>
        /// 赋值一个 SortedDataObject
        /// </summary>
        public static AssignSortedDataObjectStep StepAssignSortedDataObject<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost, string name)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            return StepCollectionExtension.StepAssignSortedDataObject(stepBuilderCollectionHost.StepCollection, name);
        }

        /// <summary>
        /// 赋值一个 DataObject
        /// </summary>
        public static TStepCollectionHost StepAssignDataObject<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost, string name, DataObject dataObject)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            StepCollectionExtension.StepAssignDataObject(stepBuilderCollectionHost.StepCollection, name, dataObject);

            return stepBuilderCollectionHost;
        }

        /// <summary>
        /// 赋值一个 DataArray
        /// </summary>
        public static AssignDataArrayStep StepAssignDataArray<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost, string name)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            return StepCollectionExtension.StepAssignDataArray(stepBuilderCollectionHost.StepCollection, name);
        }

        /// <summary>
        /// 赋值一个 DataArray
        /// </summary>
        public static TStepCollectionHost StepAssignDataArray<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost, string name, DataArray dataArray)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            StepCollectionExtension.StepAssignDataArray(stepBuilderCollectionHost.StepCollection, name, dataArray);

            return stepBuilderCollectionHost;
        }

        /// <summary>
        /// 定义一个方法
        /// </summary>
        public static DefineMethodStep StepDefineMethod<TStepCollectionHost>(this TStepCollectionHost stepBuilderCollectionHost)
            where TStepCollectionHost : IStepCollectionHost
        {
            stepBuilderCollectionHost.StepCollection = stepBuilderCollectionHost.StepCollection ?? new StepCollection();

            return StepCollectionExtension.StepDefineMethod(stepBuilderCollectionHost.StepCollection);
        }
    }
}
