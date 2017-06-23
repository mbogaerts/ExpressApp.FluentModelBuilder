using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DevExpress.Persistent.Validation;

namespace ExpressApp.FluentModelBuilder.XAF
{
    public partial class ModelBuilder<T>
    {
        #region HasRuleCriteria
        public ModelBuilder<T> HasRuleCriteria(string criteria, bool invertResult = false)
        {
            return WithAttribute(new RuleCriteriaAttribute(criteria) { InvertResult = invertResult });
        }

        public ModelBuilder<T> HasRuleCriteria(DefaultContexts targetContext, string criteria, bool invertResult = false)
        {
            return WithAttribute(new RuleCriteriaAttribute(targetContext, criteria) { InvertResult = invertResult });
        }

        public ModelBuilder<T> HasRuleCriteria(string id, DefaultContexts targetContext, string criteria, bool invertResult = false)
        {
            return WithAttribute(new RuleCriteriaAttribute(id, targetContext, criteria) { InvertResult = invertResult });
        }

        public ModelBuilder<T> HasRuleCriteria(string id, string targetContextIDs, string criteria, bool invertResult = false)
        {
            return WithAttribute(new RuleCriteriaAttribute(id, targetContextIDs, criteria) { InvertResult = invertResult });
        }

        public ModelBuilder<T> HasRuleCriteria(string id, DefaultContexts targetContext, string criteria, string messageTemplate, bool invertResult = false)
        {
            return WithAttribute(new RuleCriteriaAttribute(id, targetContext, criteria, messageTemplate) { InvertResult = invertResult });
        }

        public ModelBuilder<T> HasRuleCriteria(string id, string targetContextIDs, string criteria, string messageTemplate, bool invertResult = false)
        {
            return WithAttribute(new RuleCriteriaAttribute(id, targetContextIDs, criteria, messageTemplate) { InvertResult = invertResult });
        }
        #endregion

        #region HasRuleObjectExists
        public ModelBuilder<T> HasRuleObjectExists(string criteria, bool invertResult = false)
        {
            return WithAttribute(new RuleObjectExistsAttribute(criteria) { InvertResult = invertResult });
        }

        public ModelBuilder<T> HasRuleObjectExists(DefaultContexts targetContext, string criteria, bool invertResult = false)
        {
            return WithAttribute(new RuleObjectExistsAttribute(targetContext, criteria) { InvertResult = invertResult });
        }

        public ModelBuilder<T> HasRuleObjectExists(string id, DefaultContexts targetContext, string criteria, bool invertResult = false)
        {
            return WithAttribute(new RuleObjectExistsAttribute(id, targetContext, criteria) { InvertResult = invertResult });
        }

        public ModelBuilder<T> HasRuleObjectExists(string id, string targetContextIDs, string criteria, bool invertResult = false)
        {
            return WithAttribute(new RuleObjectExistsAttribute(id, targetContextIDs, criteria) { InvertResult = invertResult });
        }

        public ModelBuilder<T> HasRuleObjectExists(string id, DefaultContexts targetContext, string criteria, string messageTemplate, bool invertResult = false)
        {
            return WithAttribute(new RuleObjectExistsAttribute(id, targetContext, criteria, messageTemplate) { InvertResult = invertResult });
        }

        public ModelBuilder<T> HasRuleObjectExists(string id, string targetContextIDs, string criteria, string messageTemplate, bool invertResult = false)
        {
            return WithAttribute(new RuleObjectExistsAttribute(id, targetContextIDs, criteria, messageTemplate) { InvertResult = invertResult });
        }
        #endregion

        #region RuleIsReferenced
        public ModelBuilder<T> HasRuleIsReferenced(Type looksFor, string refrencePropertyName, bool invertResult = false)
        {
            return WithAttribute(new RuleIsReferencedAttribute(looksFor, refrencePropertyName) { InvertResult = invertResult });
        }

        public ModelBuilder<T> HasRuleIsReferenced(DefaultContexts targetContext, Type looksFor, string refrencePropertyName, bool invertResult = false)
        {
            return WithAttribute(new RuleIsReferencedAttribute(targetContext, looksFor, refrencePropertyName) { InvertResult = invertResult });
        }

        public ModelBuilder<T> HasRuleIsReferenced(string id, DefaultContexts targetContext, Type looksFor, string refrencePropertyName, bool invertResult = false)
        {
            return WithAttribute(new RuleIsReferencedAttribute(id, targetContext, looksFor, refrencePropertyName) { InvertResult = invertResult });
        }

        public ModelBuilder<T> HasRuleIsReferenced(string id, string targetContextIDs, Type looksFor, string refrencePropertyName, bool invertResult = false)
        {
            return WithAttribute(new RuleIsReferencedAttribute(id, targetContextIDs, looksFor, refrencePropertyName) { InvertResult = invertResult });
        }

        public ModelBuilder<T> HasRuleIsReferenced(string id, DefaultContexts targetContext, Type looksFor, string refrencePropertyName, string messageTemplate, bool invertResult = false)
        {
            return WithAttribute(new RuleIsReferencedAttribute(id, targetContext, looksFor, refrencePropertyName, messageTemplate) { InvertResult = invertResult });
        }

        public ModelBuilder<T> HasRuleIsReferenced(string id, string targetContextIDs, Type looksFor, string refrencePropertyName, string messageTemplate, bool invertResult = false)
        {
            return WithAttribute(new RuleIsReferencedAttribute(id, targetContextIDs, looksFor, refrencePropertyName, messageTemplate) { InvertResult = invertResult });
        }

        public ModelBuilder<T> HasRuleIsReferenced(Type looksFor, string refrencePropertyName, CriteriaEvaluationBehavior criteriaEvaluationBehavior, bool invertResult = false)
        {
            return WithAttribute(new RuleIsReferencedAttribute(looksFor, refrencePropertyName) { CriteriaEvaluationBehavior = criteriaEvaluationBehavior,  InvertResult = invertResult });
        }

        public ModelBuilder<T> HasRuleIsReferenced(DefaultContexts targetContext, Type looksFor, string refrencePropertyName, CriteriaEvaluationBehavior criteriaEvaluationBehavior, bool invertResult = false)
        {
            return WithAttribute(new RuleIsReferencedAttribute(targetContext, looksFor, refrencePropertyName) { CriteriaEvaluationBehavior = criteriaEvaluationBehavior, InvertResult = invertResult });
        }

        public ModelBuilder<T> HasRuleIsReferenced(DefaultContexts targetContext, Type looksFor, string refrencePropertyName, CriteriaEvaluationBehavior criteriaEvaluationBehavior, string messageTemplate, bool invertResult = false)
        {
            return WithAttribute(new RuleIsReferencedAttribute("", targetContext, looksFor, refrencePropertyName, messageTemplate) { CriteriaEvaluationBehavior = criteriaEvaluationBehavior, InvertResult = invertResult });
        }

        public ModelBuilder<T> HasRuleIsReferenced(string id, DefaultContexts targetContext, Type looksFor, string refrencePropertyName, CriteriaEvaluationBehavior criteriaEvaluationBehavior, bool invertResult = false)
        {
            return WithAttribute(new RuleIsReferencedAttribute(id, targetContext, looksFor, refrencePropertyName) { CriteriaEvaluationBehavior = criteriaEvaluationBehavior, InvertResult = invertResult });
        }

        public ModelBuilder<T> HasRuleIsReferenced(string id, string targetContextIDs, Type looksFor, string refrencePropertyName, CriteriaEvaluationBehavior criteriaEvaluationBehavior, bool invertResult = false)
        {
            return WithAttribute(new RuleIsReferencedAttribute(id, targetContextIDs, looksFor, refrencePropertyName) { CriteriaEvaluationBehavior = criteriaEvaluationBehavior, InvertResult = invertResult });
        }

        public ModelBuilder<T> HasRuleIsReferenced(string id, DefaultContexts targetContext, Type looksFor, string refrencePropertyName, string messageTemplate, CriteriaEvaluationBehavior criteriaEvaluationBehavior, bool invertResult = false)
        {
            return WithAttribute(new RuleIsReferencedAttribute(id, targetContext, looksFor, refrencePropertyName, messageTemplate) { CriteriaEvaluationBehavior = criteriaEvaluationBehavior, InvertResult = invertResult });
        }

        public ModelBuilder<T> HasRuleIsReferenced(string id, string targetContextIDs, Type looksFor, string refrencePropertyName, string messageTemplate, CriteriaEvaluationBehavior criteriaEvaluationBehavior, bool invertResult = false)
        {
            return WithAttribute(new RuleIsReferencedAttribute(id, targetContextIDs, looksFor, refrencePropertyName, messageTemplate) { CriteriaEvaluationBehavior = criteriaEvaluationBehavior, InvertResult = invertResult });
        }
        
        #endregion







    }
}