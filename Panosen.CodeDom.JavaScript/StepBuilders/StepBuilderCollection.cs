using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript
{
    /// <summary>
    /// IStepBuilderCollection
    /// </summary>
    public interface IStepBuilderCollection
    {
        /// <summary>
        /// 步骤
        /// </summary>
        List<StepBuilderOrCollection> StepBuilders { get; set; }
    }

    /// <summary>
    /// 一批语句
    /// </summary>
    public class StepBuilderCollection : StepBuilderOrCollection, IStepBuilderCollection
    {
        #region IStepBuilderCollection Members

        /// <summary>
        /// 步骤
        /// </summary>
        public List<StepBuilderOrCollection> StepBuilders { get; set; }

        #endregion
    }

    /// <summary>
    /// StepBuilderCollection 扩展
    /// </summary>
    public static class StepBuilderCollectionExtension
    {
        /// <summary>
        /// 增加一个步骤
        /// </summary>
        public static TStepBuilderCollection Step<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, StepBuilder stepBuilder)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepBuilderOrCollection>();
            }

            stepBuilderCollection.StepBuilders.Add(stepBuilder);

            return stepBuilderCollection;
        }

        /// <summary>
        /// 一个空行
        /// </summary>
        public static TStepBuilderCollection StepEmpty<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepBuilderOrCollection>();
            }

            stepBuilderCollection.StepBuilders.Add(new EmptyStepBuilder());

            return stepBuilderCollection;
        }

        /// <summary>
        /// 一行代码
        /// </summary>
        public static TStepBuilderCollection StepStatement<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, string statement)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepBuilderOrCollection>();
            }

            StatementStepBuilder statementStepBuilder = new StatementStepBuilder();
            statementStepBuilder.Statement = statement;
            stepBuilderCollection.StepBuilders.Add(statementStepBuilder);

            return stepBuilderCollection;
        }

        /// <summary>
        /// if语句块
        /// </summary>
        public static IfStepBuilder StepIf<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, string expression = null)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepBuilderOrCollection>();
            }

            IfStepBuilder ifStepBuilder = new IfStepBuilder();
            ifStepBuilder.Expression = expression;

            stepBuilderCollection.StepBuilders.Add(ifStepBuilder);

            return ifStepBuilder;
        }

        /// <summary>
        /// switch语句块
        /// </summary>
        public static SwitchStepBuilder StepSwitch<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, string expression = null)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepBuilderOrCollection>();
            }

            SwitchStepBuilder switchStepBuilder = new SwitchStepBuilder();
            switchStepBuilder.Expression = expression;

            stepBuilderCollection.StepBuilders.Add(switchStepBuilder);

            return switchStepBuilder;
        }

        /// <summary>
        /// for语句块
        /// </summary>
        public static ForStepBuilder StepFor<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, string start, string middle, string end)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepBuilderOrCollection>();
            }

            ForStepBuilder forStepBuilder = new ForStepBuilder();
            forStepBuilder.Start = start;
            forStepBuilder.Middle = middle;
            forStepBuilder.End = end;

            stepBuilderCollection.StepBuilders.Add(forStepBuilder);

            return forStepBuilder;
        }

        /// <summary>
        /// 返回DataObject
        /// </summary>
        public static ReturnDataObjectStepBuilder StepReturnDataObject<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepBuilderOrCollection>();
            }

            ReturnDataObjectStepBuilder returnComplexStepBuilder = new ReturnDataObjectStepBuilder();

            stepBuilderCollection.StepBuilders.Add(returnComplexStepBuilder);

            return returnComplexStepBuilder;
        }

        /// <summary>
        /// 返回SortedDataObject
        /// </summary>
        public static ReturnSortedDataObjectStepBuilder StepReturnSortedDataObject<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepBuilderOrCollection>();
            }

            ReturnSortedDataObjectStepBuilder returnComplexStepBuilder = new ReturnSortedDataObjectStepBuilder();

            stepBuilderCollection.StepBuilders.Add(returnComplexStepBuilder);

            return returnComplexStepBuilder;
        }

        /// <summary>
        /// 使用大括号包裹的代码段
        /// </summary>
        public static BlockStepBuilder StepBlock<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepBuilderOrCollection>();
            }

            BlockStepBuilder blockStepBuilder = new BlockStepBuilder();

            stepBuilderCollection.StepBuilders.Add(blockStepBuilder);

            return blockStepBuilder;
        }

        /// <summary>
        /// 增加缩进
        /// </summary>
        public static PushIndentStepBuilder StepPushIndent<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, string key)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepBuilderOrCollection>();
            }

            PushIndentStepBuilder pushIndentStepBuilder = new PushIndentStepBuilder();
            pushIndentStepBuilder.Key = key;

            stepBuilderCollection.StepBuilders.Add(pushIndentStepBuilder);

            return pushIndentStepBuilder;
        }

        /// <summary>
        /// 调用方法
        /// </summary>
        public static StatementChainStepBuilder StepStatementChain<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, string target = null)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepBuilderOrCollection>();
            }

            StatementChainStepBuilder statementChainStepBuilder = new StatementChainStepBuilder();
            statementChainStepBuilder.Target = target;

            stepBuilderCollection.StepBuilders.Add(statementChainStepBuilder);

            return statementChainStepBuilder;
        }

        /// <summary>
        /// 在当前步骤定义方法
        /// function add() { }
        /// </summary>
        public static TStepBuilderCollection StepDefineMethod<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, CodeMethod codeMethod)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepBuilderOrCollection>();
            }

            DefineMethodStepBuilder defineMethodStepBuilder = new DefineMethodStepBuilder();
            defineMethodStepBuilder.Method = codeMethod;

            stepBuilderCollection.StepBuilders.Add(defineMethodStepBuilder);

            return stepBuilderCollection;
        }

        /// <summary>
        /// 在当前步骤将方法赋值给指定变量
        /// name = function () { }
        /// </summary>

        /// <returns></returns>
        public static CodeMethod StepAssignMethod<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, string name)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepBuilderOrCollection>();
            }

            CodeMethod codeMethod = new CodeMethod();

            AssignMethodStepBuilder assignMethodStepBuilder = new AssignMethodStepBuilder();
            assignMethodStepBuilder.VariableName = name;
            assignMethodStepBuilder.CodeMethod = codeMethod;

            stepBuilderCollection.StepBuilders.Add(assignMethodStepBuilder);

            return codeMethod;
        }

        /// <summary>
        /// 在当前步骤将方法赋值给指定变量
        /// name = function () { }
        /// </summary>
        public static TStepBuilderCollection StepAssignMethod<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, string name, CodeMethod codeMethod)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepBuilderOrCollection>();
            }

            AssignMethodStepBuilder assignMethodStepBuilder = new AssignMethodStepBuilder();
            assignMethodStepBuilder.VariableName = name;
            assignMethodStepBuilder.CodeMethod = codeMethod;

            stepBuilderCollection.StepBuilders.Add(assignMethodStepBuilder);

            return stepBuilderCollection;
        }

        /// <summary>
        /// 赋值一个 DataObject
        /// </summary>
        public static AssignDataObjectStepBuilder StepAssignDataObject<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, string name)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepBuilderOrCollection>();
            }

            AssignDataObjectStepBuilder assignMethodStepBuilder = new AssignDataObjectStepBuilder();
            assignMethodStepBuilder.Name = name;

            stepBuilderCollection.StepBuilders.Add(assignMethodStepBuilder);

            return assignMethodStepBuilder;
        }

        /// <summary>
        /// 赋值一个 SortedDataObject
        /// </summary>
        public static AssignSortedDataObjectStepBuilder StepAssignSortedDataObject<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, string name)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepBuilderOrCollection>();
            }

            AssignSortedDataObjectStepBuilder assignMethodStepBuilder = new AssignSortedDataObjectStepBuilder();
            assignMethodStepBuilder.Name = name;

            stepBuilderCollection.StepBuilders.Add(assignMethodStepBuilder);

            return assignMethodStepBuilder;
        }

        /// <summary>
        /// 赋值一个 DataObject
        /// </summary>
        public static TStepBuilderCollection StepAssignDataObject<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, string name, DataObject dataObject)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepBuilderOrCollection>();
            }

            AssignDataObjectStepBuilder assignMethodStepBuilder = new AssignDataObjectStepBuilder();
            assignMethodStepBuilder.Name = name;
            assignMethodStepBuilder.DataObject = dataObject;

            stepBuilderCollection.StepBuilders.Add(assignMethodStepBuilder);

            return stepBuilderCollection;
        }

        /// <summary>
        /// 赋值一个 DataArray
        /// </summary>
        public static AssignDataArrayStepBuilder StepAssignDataArray<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, string name)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepBuilderOrCollection>();
            }

            AssignDataArrayStepBuilder assignMethodStepBuilder = new AssignDataArrayStepBuilder();
            assignMethodStepBuilder.Name = name;

            stepBuilderCollection.StepBuilders.Add(assignMethodStepBuilder);

            return assignMethodStepBuilder;
        }

        /// <summary>
        /// 赋值一个 DataArray
        /// </summary>
        public static TStepBuilderCollection StepAssignDataArray<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, string name, DataArray dataArray)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepBuilderOrCollection>();
            }

            AssignDataArrayStepBuilder assignMethodStepBuilder = new AssignDataArrayStepBuilder();
            assignMethodStepBuilder.Name = name;
            assignMethodStepBuilder.DataArray = dataArray;

            stepBuilderCollection.StepBuilders.Add(assignMethodStepBuilder);

            return stepBuilderCollection;
        }

        /// <summary>
        /// 定义一个方法
        /// </summary>
        public static DefineMethodStepBuilder StepDefineMethod<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepBuilderOrCollection>();
            }

            DefineMethodStepBuilder defineMethodStepBuilder = new DefineMethodStepBuilder();

            stepBuilderCollection.StepBuilders.Add(defineMethodStepBuilder);

            return defineMethodStepBuilder;
        }
    }
}
