using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.ExpressApp.Model;

namespace ExpressApp.FluentModelBuilder.XAF
{
    public partial class ModelBuilder<T>
    {


        public ModelBuilder<T> WithModelDefault(string propertyName, string propertyValue)
        {
            return WithAttribute(new ModelDefaultAttribute(propertyName, propertyValue));
        }

        public ModelBuilder<T> NotAllowingEdit()
        {
            return WithModelDefault("AllowEdit", "false");
        }

        public ModelBuilder<T> AllowingEdit()
        {
            return WithModelDefault("AllowEdit", "true");
        }

        public ModelBuilder<T> NotAllowingNew()
        {
            return WithModelDefault("AllowNew", "false");
        }

        public ModelBuilder<T> AllowingNew()
        {
            return WithModelDefault("AllowNew", "true");
        }

        public ModelBuilder<T> NotAllowingDelete()
        {
            return WithModelDefault("AllowDelete", "false");
        }

        public ModelBuilder<T> AllowingDelete()
        {
            return WithModelDefault("AllowDelete", "true");
        }

        public ModelBuilder<T> AllowingNothing()
        {
            return NotAllowingDelete().NotAllowingEdit().NotAllowingNew();
        }

        public ModelBuilder<T> AllowingEverything()
        {
            return AllowingDelete().AllowingEdit().AllowingNew();
        }

        public ModelBuilder<T> HasCaption(string caption)
        {
            return WithModelDefault(ModelDefaultKeys.Caption, caption);
        }

        public ModelBuilder<T> HasShowAutoFilterRow(bool isVisible = true)
        {
            return WithModelDefault(ModelDefaultKeys.DefaultListViewShowAutoFilterRow, isVisible.ToString());
        }
    }
}
