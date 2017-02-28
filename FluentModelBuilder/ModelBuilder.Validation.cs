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

        

        

        

        
    }
}