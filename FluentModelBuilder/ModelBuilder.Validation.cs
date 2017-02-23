using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DevExpress.Persistent.Validation;

namespace ExpressApp.FluentModelBuilder.XAF
{
    public partial class ModelBuilder<T>
    {
        #region HasRuleObjectExists
        public ModelBuilder<T> HasRuleObjectExists(string criteria)
        {
            return WithAttribute(new RuleObjectExistsAttribute(criteria));
        }

        public ModelBuilder<T> HasRuleObjectExists(DefaultContexts targetContext, string criteria)
        {
            return WithAttribute(new RuleObjectExistsAttribute(targetContext, criteria));
        }

        public ModelBuilder<T> HasRuleObjectExists(string id, DefaultContexts targetContext, string criteria)
        {
            return WithAttribute(new RuleObjectExistsAttribute(id, targetContext, criteria));
        }

        public ModelBuilder<T> HasRuleObjectExists(string id, string targetContextIDs, string criteria)
        {
            return WithAttribute(new RuleObjectExistsAttribute(id, targetContextIDs, criteria));
        }

        public ModelBuilder<T> HasRuleObjectExists(string id, DefaultContexts targetContext, string criteria, string messageTemplate)
        {
            return WithAttribute(new RuleObjectExistsAttribute(id, targetContext, criteria, messageTemplate));
        }

        public ModelBuilder<T> HasRuleObjectExists(string id, string targetContextIDs, string criteria, string messageTemplate)
        {
            return WithAttribute(new RuleObjectExistsAttribute(id, targetContextIDs, criteria, messageTemplate));
        }
        #endregion

        #region HasRuleCriteria
        public ModelBuilder<T> HasRuleCriteria(string criteria)
        {
            return WithAttribute(new RuleCriteriaAttribute(criteria));
        }

        public ModelBuilder<T> HasRuleCriteria(DefaultContexts targetContext, string criteria)
        {
            return WithAttribute(new RuleCriteriaAttribute(targetContext, criteria));
        }

        public ModelBuilder<T> HasRuleCriteria(string id, DefaultContexts targetContext, string criteria)
        {
            return WithAttribute(new RuleCriteriaAttribute(id, targetContext, criteria));
        }

        public ModelBuilder<T> HasRuleCriteria(string id, string targetContextIDs, string criteria)
        {
            return WithAttribute(new RuleCriteriaAttribute(id, targetContextIDs, criteria));
        }

        public ModelBuilder<T> HasRuleCriteria(string id, DefaultContexts targetContext, string criteria, string messageTemplate)
        {
            return WithAttribute(new RuleCriteriaAttribute(id, targetContext, criteria, messageTemplate));
        }

        public ModelBuilder<T> HasRuleCriteria(string id, string targetContextIDs, string criteria, string messageTemplate)
        {
            return WithAttribute(new RuleCriteriaAttribute(id, targetContextIDs, criteria, messageTemplate));
        }
        #endregion

        #region HasRuleValueComparison
        public ModelBuilder<T> HasRuleValueComparison(ValueComparisonType operatorType, object rightOperand)
        {
            return WithAttribute(new RuleValueComparisonAttribute(operatorType, rightOperand));
        }

        public ModelBuilder<T> HasRuleValueComparison(DefaultContexts targetContexts, ValueComparisonType operatorType, object rightOperand)
        {
            return WithAttribute(new RuleValueComparisonAttribute(targetContexts, operatorType, rightOperand));
        }

        public ModelBuilder<T> HasRuleValueComparison(string id, string targetContextIDs, ValueComparisonType operatorType, object rightOperand)
        {
            return WithAttribute(new RuleValueComparisonAttribute(id, targetContextIDs, operatorType, rightOperand));
        }

        public ModelBuilder<T> HasRuleValueComparison(string id, DefaultContexts targetContexts, ValueComparisonType operatorType, object rightOperand)
        {
            return WithAttribute(new RuleValueComparisonAttribute(id, targetContexts, operatorType, rightOperand));
        }

        public ModelBuilder<T> HasRuleValueComparison(string id, DefaultContexts targetContexts, ValueComparisonType operatorType, object rightOperand, string messageTemplate)
        {
            return WithAttribute(new RuleValueComparisonAttribute(id, targetContexts, operatorType, rightOperand, messageTemplate));
        }

        public ModelBuilder<T> HasRuleValueComparison(string id, string targetContextIDs, ValueComparisonType operatorType, object rightOperand, string messageTemplate)
        {
            return WithAttribute(new RuleValueComparisonAttribute(id, targetContextIDs, operatorType, rightOperand, messageTemplate));
        }

        public ModelBuilder<T> HasRuleValueComparison(string id, DefaultContexts targetContexts, ValueComparisonType operatorType, string rightOperand, ParametersMode mode)
        {
            return WithAttribute(new RuleValueComparisonAttribute(id, targetContexts, operatorType, rightOperand, mode));
        }

        public ModelBuilder<T> HasRuleValueComparison(string id, string targetContextIDs, ValueComparisonType operatorType, string rightOperand, ParametersMode mode)
        {
            return WithAttribute(new RuleValueComparisonAttribute(id, targetContextIDs, operatorType, rightOperand, mode));
        }

        public ModelBuilder<T> HasRuleValueComparison(string id, DefaultContexts targetContexts, ValueComparisonType operatorType, string rightOperand, string messageTemplate, ParametersMode mode)
        {
            return WithAttribute(new RuleValueComparisonAttribute(id, targetContexts, operatorType, rightOperand, messageTemplate, mode));
        }

        public ModelBuilder<T> HasRuleValueComparison(string id, string targetContextIDs, ValueComparisonType operatorType, string rightOperand, string messageTemplate, ParametersMode mode)
        {
            return WithAttribute(new RuleValueComparisonAttribute(id, targetContextIDs, operatorType, rightOperand, messageTemplate, mode));
        }




        #endregion

        #region HasRuleUniqueValue
        public ModelBuilder<T> HasRuleUniqueValue()
        {
            return WithAttribute(new RuleUniqueValueAttribute());
        }

        public ModelBuilder<T> HasRuleUniqueValue(DefaultContexts targetContexts)
        {
            return WithAttribute(new RuleUniqueValueAttribute(targetContexts));
        }

        public ModelBuilder<T> HasRuleUniqueValue(string id, string targetContextsIDs)
        {
            return WithAttribute(new RuleUniqueValueAttribute(id, targetContextsIDs));
        }


        public ModelBuilder<T> HasRuleUniqueValue(string id, DefaultContexts targetContexts)
        {
            return WithAttribute(new RuleUniqueValueAttribute(id, targetContexts));
        }

        public ModelBuilder<T> HasRuleUniqueValue(string id, DefaultContexts targetContexts, string messageTemplate)
        {
            return WithAttribute(new RuleUniqueValueAttribute(id, targetContexts, messageTemplate));
        }

        public ModelBuilder<T> HasRuleUniqueValue(string id, string targetContextsIDs, string messageTemplate)
        {
            return WithAttribute(new RuleUniqueValueAttribute(id, targetContextsIDs, messageTemplate));
        }
        #endregion

        #region HasRuleStringComparison
        public ModelBuilder<T> HasRuleStringComparison(StringComparisonType operatorType, string operandValue)
        {
            return WithAttribute(new RuleStringComparisonAttribute(operatorType, operandValue));
        }

        public ModelBuilder<T> HasRuleStringComparison(DefaultContexts targetContexts, StringComparisonType operatorType, string operandValue)
        {
            return WithAttribute(new RuleStringComparisonAttribute(targetContexts, operatorType, operandValue));
        }

        public ModelBuilder<T> HasRuleStringComparison(string id, string targetContextIDs, StringComparisonType operatorType, string operandValue)
        {
            return WithAttribute(new RuleStringComparisonAttribute(id, targetContextIDs, operatorType, operandValue));
        }

        public ModelBuilder<T> HasRuleStringComparison(string id, DefaultContexts targetContexts, StringComparisonType operatorType, string operandValue)
        {
            return WithAttribute(new RuleStringComparisonAttribute(id, targetContexts, operatorType, operandValue));
        }

        public ModelBuilder<T> HasRuleStringComparison(string id, DefaultContexts targetContexts, StringComparisonType operatorType, string operandValue, string messageTemplate)
        {
            return WithAttribute(new RuleStringComparisonAttribute(id, targetContexts, operatorType, operandValue, messageTemplate));
        }

        public ModelBuilder<T> HasRuleStringComparison(string id, string targetContextIDs, StringComparisonType operatorType, string operandValue, string messageTemplate)
        {
            return WithAttribute(new RuleStringComparisonAttribute(id, targetContextIDs, operatorType, operandValue, messageTemplate));
        }
        #endregion

        #region HasRuleRequiredField
        public ModelBuilder<T> HasRuleRequiredField()
        {
            return WithAttribute(new RuleRequiredFieldAttribute());
        }

        public ModelBuilder<T> HasRuleRequiredField(DefaultContexts targetContexts)
        {
            return WithAttribute(new RuleRequiredFieldAttribute(targetContexts));
        }

        public ModelBuilder<T> HasRuleRequiredField(string id, DefaultContexts targetContexts)
        {
            return WithAttribute(new RuleRequiredFieldAttribute(id, targetContexts));
        }

        public ModelBuilder<T> HasRuleRequiredField(string id, string targetContextIDs)
        {
            return WithAttribute(new RuleRequiredFieldAttribute(id, targetContextIDs));
        }

        public ModelBuilder<T> HasRuleRequiredField(string id, DefaultContexts targetContexts, string messageTemplate)
        {
            return WithAttribute(new RuleRequiredFieldAttribute(id, targetContexts, messageTemplate));
        }

        public ModelBuilder<T> HasRuleRequiredField(string id, string targetContextIDs, string messageTemplate)
        {
            return WithAttribute(new RuleRequiredFieldAttribute(id, targetContextIDs, messageTemplate));
        }

        #endregion
    }
}