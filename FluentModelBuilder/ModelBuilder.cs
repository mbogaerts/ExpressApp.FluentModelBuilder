﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.Persistent.Base;

namespace ExpressApp.FluentModelBuilder.XAF
{
    public static class ModelBuilder
    {
        public static ITypeInfo FindTypeInfo<T>(this ITypesInfo typesInfo)
        {
            return typesInfo.FindTypeInfo(typeof(T));
        }

        public static ModelBuilder<T> Create<T>(ITypesInfo typesInfo)
        {
            return new ModelBuilder<T>(typesInfo.FindTypeInfo<T>());
        }

        public static ModelBuilder<T> Create<T>()
        {
            return Create<T>(XafTypesInfo.Instance);
        }
    }

    public partial class ModelBuilder<T> : IBuilderManager, ITypeInfoProvider
    {
        public ITypeInfo TypeInfo { get; private set; }

        public readonly Fields<T> _Fields;

        public readonly List<IBuilder> _Builders = new List<IBuilder>();

        public ModelBuilder(ITypesInfo typesInfo)
            : this(typesInfo.FindTypeInfo<T>())
        {

        }

        public ModelBuilder(ITypeInfo typeInfo)
        {
            TypeInfo = typeInfo;
            _Fields = new Fields<T>();

            BuildUp();
        }

        protected virtual void BuildUp()
        {

        }

        public ModelBuilder<T> WithAttribute(Attribute attribute)
        {
            TypeInfo.AddAttribute(attribute);
            return this;
        }

        public ModelBuilder<T> WithAttribute<TAttribute>() where TAttribute : Attribute, new()
        {
            return WithAttribute<TAttribute>(a => { });
        }

        public ModelBuilder<T> WithAttribute<TAttribute>(Action<TAttribute> configureAction) where TAttribute : Attribute, new()
        {
            var attribute = new TAttribute();

            configureAction(attribute);

            TypeInfo.AddAttribute(attribute);
            return this;
        }

        public ModelBuilder<T> IsNavigationItem(string groupName)
        {
            return WithAttribute(new NavigationItemAttribute(groupName));
        }

        public ModelBuilder<T> HasListViewFindPanel()
        {
            return WithAttribute(new ListViewFindPanelAttribute(true));
        }

        //DefaultListViewOptions
        public ModelBuilder<T> HasDefaultListViewOptions(MasterDetailMode masterDetailMode)
        {
            return WithAttribute(new DefaultListViewOptionsAttribute(masterDetailMode));
        }

        public ModelBuilder<T> HasDefaultListViewOptions(bool allowEdit, NewItemRowPosition newItemRowPosition)
        {
            return WithAttribute(new DefaultListViewOptionsAttribute(allowEdit, newItemRowPosition));
        }

        public ModelBuilder<T> HasDefaultListViewOptions(MasterDetailMode masterDetailMode, bool allowEdit, NewItemRowPosition newItemRowPosition)
        {
            return WithAttribute(new DefaultListViewOptionsAttribute(masterDetailMode, allowEdit, newItemRowPosition));
        }

        public ModelBuilder<T> HasImage(string imageName)
        {
            return WithAttribute(new ImageNameAttribute(imageName));
        }

        public PropertyBuilder<TProp, T> For<TProp>(Expression<Func<T, TProp>> propertyName)
        {
            var builder = PropertyBuilderFactory.PropertyBuilderFactoryMethod<TProp, T>(TypeInfo.FindMember(_Fields.GetPropertyName(propertyName)));

            _Builders.Add(builder);

            return builder;
        }

        public ModelBuilder<T> HasDefaultProperty<TProp>(Expression<Func<T, TProp>> propertyName)
        {
            return HasDefaultProperty(_Fields.GetPropertyName(propertyName));
        }

        public ModelBuilder<T> HasDefaultProperty(string propertyName)
        {
            return WithAttribute(new System.ComponentModel.DefaultPropertyAttribute(propertyName));
        }

        public ModelBuilder<T> HasObjectCaptionFormat(string formatString)
        {
            return WithAttribute(new ObjectCaptionFormatAttribute(formatString));
        }

        public ModelBuilder<T> HasObjectCaptionFormat<TProp>(Expression<Func<T, TProp>> formatString)
        {
            return WithAttribute(new ObjectCaptionFormatAttribute("{0:" + _Fields.GetPropertyName(formatString) + "}"));
        }



        void IBuilderManager.AddBuilder(IBuilder builder)
        {
            _Builders.Add(builder);
        }

        void IBuilder.Build()
        {
            _Builders.ForEach(b => b.Build());
        }
    }
}