using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DevExpress.ExpressApp.SystemModule;

namespace ExpressApp.FluentModelBuilder.XAF
{
    public partial class ModelBuilder<T>
    {
        public ModelBuilder<T> HasListViewFilter(string id, string criteria)
        {
            return WithAttribute(new ListViewFilterAttribute(id, criteria));
        }

        public ModelBuilder<T> HasListViewFilter(string id, string criteria, bool isCurrentFilter)
        {
            return WithAttribute(new ListViewFilterAttribute(id, criteria, isCurrentFilter));
        }

        public ModelBuilder<T> HasListViewFilter(string id, string criteria, string caption)
        {
            return WithAttribute(new ListViewFilterAttribute(id, criteria, caption));
        }

        public ModelBuilder<T> HasListViewFilter(string id, string criteria, string caption, bool isCurrentFilter)
        {
            return WithAttribute(new ListViewFilterAttribute(id, criteria, caption, isCurrentFilter));
        }

        public ModelBuilder<T> HasListViewFilter(string id, string criteria, string caption, string description, bool isCurrentFilter)
        {
            return WithAttribute(new ListViewFilterAttribute(id, criteria, caption, description, isCurrentFilter));
        }

        public ModelBuilder<T> HasListViewFilter(string id, string criteria, string caption, string description, int index, bool isCurrentFilter)
        {
            return WithAttribute(new ListViewFilterAttribute(id, criteria, caption, description, index, isCurrentFilter));
        }
    }
}
