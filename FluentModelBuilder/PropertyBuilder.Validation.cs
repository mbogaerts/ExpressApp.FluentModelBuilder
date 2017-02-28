using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using DevExpress.Persistent.Validation;

namespace ExpressApp.FluentModelBuilder.XAF
{
    public partial class PropertyBuilder<T, TType>
    {
        

        #region HasRuleValueComparison
        public PropertyBuilder<T, TType> HasRuleValueComparison(ValueComparisonType operatorType, object rightOperand)
        {
            return WithAttribute(new RuleValueComparisonAttribute(operatorType, rightOperand));
        }

        public PropertyBuilder<T, TType> HasRuleValueComparison(DefaultContexts targetContexts, ValueComparisonType operatorType, object rightOperand)
        {
            return WithAttribute(new RuleValueComparisonAttribute(targetContexts, operatorType, rightOperand));
        }

        public PropertyBuilder<T, TType> HasRuleValueComparison(string id, string targetContextIDs, ValueComparisonType operatorType, object rightOperand)
        {
            return WithAttribute(new RuleValueComparisonAttribute(id, targetContextIDs, operatorType, rightOperand));
        }

        public PropertyBuilder<T, TType> HasRuleValueComparison(string id, DefaultContexts targetContexts, ValueComparisonType operatorType, object rightOperand)
        {
            return WithAttribute(new RuleValueComparisonAttribute(id, targetContexts, operatorType, rightOperand));
        }

        public PropertyBuilder<T, TType> HasRuleValueComparison(string id, DefaultContexts targetContexts, ValueComparisonType operatorType, object rightOperand, string messageTemplate)
        {
            return WithAttribute(new RuleValueComparisonAttribute(id, targetContexts, operatorType, rightOperand, messageTemplate));
        }

        public PropertyBuilder<T, TType> HasRuleValueComparison(string id, string targetContextIDs, ValueComparisonType operatorType, object rightOperand, string messageTemplate)
        {
            return WithAttribute(new RuleValueComparisonAttribute(id, targetContextIDs, operatorType, rightOperand, messageTemplate));
        }

        public PropertyBuilder<T, TType> HasRuleValueComparison(string id, DefaultContexts targetContexts, ValueComparisonType operatorType, string rightOperand, ParametersMode mode)
        {
            return WithAttribute(new RuleValueComparisonAttribute(id, targetContexts, operatorType, rightOperand, mode));
        }

        public PropertyBuilder<T, TType> HasRuleValueComparison(string id, string targetContextIDs, ValueComparisonType operatorType, string rightOperand, ParametersMode mode)
        {
            return WithAttribute(new RuleValueComparisonAttribute(id, targetContextIDs, operatorType, rightOperand, mode));
        }

        public PropertyBuilder<T, TType> HasRuleValueComparison(string id, DefaultContexts targetContexts, ValueComparisonType operatorType, string rightOperand, string messageTemplate, ParametersMode mode)
        {
            return WithAttribute(new RuleValueComparisonAttribute(id, targetContexts, operatorType, rightOperand, messageTemplate, mode));
        }

        public PropertyBuilder<T, TType> HasRuleValueComparison(string id, string targetContextIDs, ValueComparisonType operatorType, string rightOperand, string messageTemplate, ParametersMode mode)
        {
            return WithAttribute(new RuleValueComparisonAttribute(id, targetContextIDs, operatorType, rightOperand, messageTemplate, mode));
        }




        #endregion

        #region HasRuleUniqueValue
        public PropertyBuilder<T, TType> HasRuleUniqueValue()
        {
            return WithAttribute(new RuleUniqueValueAttribute());
        }

        public PropertyBuilder<T, TType> HasRuleUniqueValue(DefaultContexts targetContexts)
        {
            return WithAttribute(new RuleUniqueValueAttribute(targetContexts));
        }

        public PropertyBuilder<T, TType> HasRuleUniqueValue(string id, string targetContextsIDs)
        {
            return WithAttribute(new RuleUniqueValueAttribute(id, targetContextsIDs));
        }


        public PropertyBuilder<T, TType> HasRuleUniqueValue(string id, DefaultContexts targetContexts)
        {
            return WithAttribute(new RuleUniqueValueAttribute(id, targetContexts));
        }

        public PropertyBuilder<T, TType> HasRuleUniqueValue(string id, DefaultContexts targetContexts, string messageTemplate)
        {
            return WithAttribute(new RuleUniqueValueAttribute(id, targetContexts, messageTemplate));
        }

        public PropertyBuilder<T, TType> HasRuleUniqueValue(string id, string targetContextsIDs, string messageTemplate)
        {
            return WithAttribute(new RuleUniqueValueAttribute(id, targetContextsIDs, messageTemplate));
        }
        #endregion

        #region HasRuleStringComparison
        public PropertyBuilder<T, TType> HasRuleStringComparison(StringComparisonType operatorType, string operandValue)
        {
            return WithAttribute(new RuleStringComparisonAttribute(operatorType, operandValue));
        }

        public PropertyBuilder<T, TType> HasRuleStringComparison(DefaultContexts targetContexts, StringComparisonType operatorType, string operandValue)
        {
            return WithAttribute(new RuleStringComparisonAttribute(targetContexts, operatorType, operandValue));
        }

        public PropertyBuilder<T, TType> HasRuleStringComparison(string id, string targetContextIDs, StringComparisonType operatorType, string operandValue)
        {
            return WithAttribute(new RuleStringComparisonAttribute(id, targetContextIDs, operatorType, operandValue));
        }

        public PropertyBuilder<T, TType> HasRuleStringComparison(string id, DefaultContexts targetContexts, StringComparisonType operatorType, string operandValue)
        {
            return WithAttribute(new RuleStringComparisonAttribute(id, targetContexts, operatorType, operandValue));
        }

        public PropertyBuilder<T, TType> HasRuleStringComparison(string id, DefaultContexts targetContexts, StringComparisonType operatorType, string operandValue, string messageTemplate)
        {
            return WithAttribute(new RuleStringComparisonAttribute(id, targetContexts, operatorType, operandValue, messageTemplate));
        }

        public PropertyBuilder<T, TType> HasRuleStringComparison(string id, string targetContextIDs, StringComparisonType operatorType, string operandValue, string messageTemplate)
        {
            return WithAttribute(new RuleStringComparisonAttribute(id, targetContextIDs, operatorType, operandValue, messageTemplate));
        }
        #endregion

        #region HasRuleRequiredField
        public PropertyBuilder<T, TType> HasRuleRequiredField()
        {
            return WithAttribute(new RuleRequiredFieldAttribute());
        }

        public PropertyBuilder<T, TType> HasRuleRequiredField(DefaultContexts targetContexts)
        {
            return WithAttribute(new RuleRequiredFieldAttribute(targetContexts));
        }

        public PropertyBuilder<T, TType> HasRuleRequiredField(string id, DefaultContexts targetContexts)
        {
            return WithAttribute(new RuleRequiredFieldAttribute(id, targetContexts));
        }

        public PropertyBuilder<T, TType> HasRuleRequiredField(string id, string targetContextIDs)
        {
            return WithAttribute(new RuleRequiredFieldAttribute(id, targetContextIDs));
        }

        public PropertyBuilder<T, TType> HasRuleRequiredField(string id, DefaultContexts targetContexts, string messageTemplate)
        {
            return WithAttribute(new RuleRequiredFieldAttribute(id, targetContexts, messageTemplate));
        }

        public PropertyBuilder<T, TType> HasRuleRequiredField(string id, string targetContextIDs, string messageTemplate)
        {
            return WithAttribute(new RuleRequiredFieldAttribute(id, targetContextIDs, messageTemplate));
        }

        #endregion
    }
}
