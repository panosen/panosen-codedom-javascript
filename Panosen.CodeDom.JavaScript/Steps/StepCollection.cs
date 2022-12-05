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
        List<StepOrCollection> StepBuilders { get; set; }
    }

    /// <summary>
    /// 一批语句
    /// </summary>
    public class StepCollection : StepOrCollection, IStepBuilderCollection
    {
        #region IStepBuilderCollection Members

        /// <summary>
        /// 步骤
        /// </summary>
        public List<StepOrCollection> StepBuilders { get; set; }

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
        public static TStepBuilderCollection Step<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, Step stepBuilder)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepOrCollection>();
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
                stepBuilderCollection.StepBuilders = new List<StepOrCollection>();
            }

            stepBuilderCollection.StepBuilders.Add(new EmptyStep());

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
                stepBuilderCollection.StepBuilders = new List<StepOrCollection>();
            }

            StatementStep statementStepBuilder = new StatementStep();
            statementStepBuilder.Statement = statement;
            stepBuilderCollection.StepBuilders.Add(statementStepBuilder);

            return stepBuilderCollection;
        }

        /// <summary>
        /// if语句块
        /// </summary>
        public static IfStep StepIf<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, string expression = null)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepOrCollection>();
            }

            IfStep ifStepBuilder = new IfStep();
            ifStepBuilder.Expression = expression;

            stepBuilderCollection.StepBuilders.Add(ifStepBuilder);

            return ifStepBuilder;
        }

        /// <summary>
        /// switch语句块
        /// </summary>
        public static SwitchStep StepSwitch<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, string expression = null)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepOrCollection>();
            }

            SwitchStep switchStepBuilder = new SwitchStep();
            switchStepBuilder.Expression = expression;

            stepBuilderCollection.StepBuilders.Add(switchStepBuilder);

            return switchStepBuilder;
        }

        /// <summary>
        /// for语句块
        /// </summary>
        public static ForStep StepFor<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, string start, string middle, string end)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepOrCollection>();
            }

            ForStep forStepBuilder = new ForStep();
            forStepBuilder.Start = start;
            forStepBuilder.Middle = middle;
            forStepBuilder.End = end;

            stepBuilderCollection.StepBuilders.Add(forStepBuilder);

            return forStepBuilder;
        }

        /// <summary>
        /// 返回DataObject
        /// </summary>
        public static ReturnDataObjectStep StepReturnDataObject<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepOrCollection>();
            }

            ReturnDataObjectStep returnComplexStepBuilder = new ReturnDataObjectStep();

            stepBuilderCollection.StepBuilders.Add(returnComplexStepBuilder);

            return returnComplexStepBuilder;
        }

        /// <summary>
        /// 返回SortedDataObject
        /// </summary>
        public static ReturnSortedDataObjectStep StepReturnSortedDataObject<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepOrCollection>();
            }

            ReturnSortedDataObjectStep returnComplexStepBuilder = new ReturnSortedDataObjectStep();

            stepBuilderCollection.StepBuilders.Add(returnComplexStepBuilder);

            return returnComplexStepBuilder;
        }

        /// <summary>
        /// 使用大括号包裹的代码段
        /// </summary>
        public static BlockStep StepBlock<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepOrCollection>();
            }

            BlockStep blockStepBuilder = new BlockStep();

            stepBuilderCollection.StepBuilders.Add(blockStepBuilder);

            return blockStepBuilder;
        }

        /// <summary>
        /// 增加缩进
        /// </summary>
        public static PushIndentStep StepPushIndent<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, string key)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepOrCollection>();
            }

            PushIndentStep pushIndentStepBuilder = new PushIndentStep();
            pushIndentStepBuilder.Key = key;

            stepBuilderCollection.StepBuilders.Add(pushIndentStepBuilder);

            return pushIndentStepBuilder;
        }

        /// <summary>
        /// 调用方法
        /// </summary>
        public static StatementChainStep StepStatementChain<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, string target = null)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepOrCollection>();
            }

            StatementChainStep statementChainStepBuilder = new StatementChainStep();
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
                stepBuilderCollection.StepBuilders = new List<StepOrCollection>();
            }

            DefineMethodStep defineMethodStepBuilder = new DefineMethodStep();
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
                stepBuilderCollection.StepBuilders = new List<StepOrCollection>();
            }

            CodeMethod codeMethod = new CodeMethod();

            AssignMethodStep assignMethodStepBuilder = new AssignMethodStep();
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
                stepBuilderCollection.StepBuilders = new List<StepOrCollection>();
            }

            AssignMethodStep assignMethodStepBuilder = new AssignMethodStep();
            assignMethodStepBuilder.VariableName = name;
            assignMethodStepBuilder.CodeMethod = codeMethod;

            stepBuilderCollection.StepBuilders.Add(assignMethodStepBuilder);

            return stepBuilderCollection;
        }

        /// <summary>
        /// 赋值一个 DataObject
        /// </summary>
        public static AssignDataObjectStep StepAssignDataObject<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, string name)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepOrCollection>();
            }

            AssignDataObjectStep assignMethodStepBuilder = new AssignDataObjectStep();
            assignMethodStepBuilder.Name = name;

            stepBuilderCollection.StepBuilders.Add(assignMethodStepBuilder);

            return assignMethodStepBuilder;
        }

        /// <summary>
        /// 赋值一个 SortedDataObject
        /// </summary>
        public static AssignSortedDataObjectStep StepAssignSortedDataObject<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, string name)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepOrCollection>();
            }

            AssignSortedDataObjectStep assignMethodStepBuilder = new AssignSortedDataObjectStep();
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
                stepBuilderCollection.StepBuilders = new List<StepOrCollection>();
            }

            AssignDataObjectStep assignMethodStepBuilder = new AssignDataObjectStep();
            assignMethodStepBuilder.Name = name;
            assignMethodStepBuilder.DataObject = dataObject;

            stepBuilderCollection.StepBuilders.Add(assignMethodStepBuilder);

            return stepBuilderCollection;
        }

        /// <summary>
        /// 赋值一个 DataArray
        /// </summary>
        public static AssignDataArrayStep StepAssignDataArray<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection, string name)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepOrCollection>();
            }

            AssignDataArrayStep assignMethodStepBuilder = new AssignDataArrayStep();
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
                stepBuilderCollection.StepBuilders = new List<StepOrCollection>();
            }

            AssignDataArrayStep assignMethodStepBuilder = new AssignDataArrayStep();
            assignMethodStepBuilder.Name = name;
            assignMethodStepBuilder.DataArray = dataArray;

            stepBuilderCollection.StepBuilders.Add(assignMethodStepBuilder);

            return stepBuilderCollection;
        }

        /// <summary>
        /// 定义一个方法
        /// </summary>
        public static DefineMethodStep StepDefineMethod<TStepBuilderCollection>(this TStepBuilderCollection stepBuilderCollection)
            where TStepBuilderCollection : IStepBuilderCollection
        {
            if (stepBuilderCollection.StepBuilders == null)
            {
                stepBuilderCollection.StepBuilders = new List<StepOrCollection>();
            }

            DefineMethodStep defineMethodStepBuilder = new DefineMethodStep();

            stepBuilderCollection.StepBuilders.Add(defineMethodStepBuilder);

            return defineMethodStepBuilder;
        }
    }
}
