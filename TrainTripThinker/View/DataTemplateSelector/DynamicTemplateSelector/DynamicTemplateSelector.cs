using System.Windows;
using System.Windows.Controls;

namespace TrainTripThinker.View
{
    /// <summary>
    /// DynamicResouceでDataTemplateを無理矢理流し込むDataTemplateSelector
    /// </summary>
    /// <remarks>
    /// DataTemplateSelectorはDependencyObjectを継承していないので、
    /// 添付プロパティを利用してDataTemplateの依存関係プロパティを付加する
    /// 実装技術は下記URL参照
    /// https://www.codeproject.com/Articles/418250/WPF-Based-Dynamic-DataTemplateSelector
    /// </remarks>
    public class DynamicTemplateSelector : DataTemplateSelector
    {
        public static DependencyProperty TemplatesProperty = DependencyProperty.RegisterAttached(
            "Templates",
            typeof(DataTemplateHolderCollection),
            typeof(DataTemplateSelector),
            new FrameworkPropertyMetadata(
                new DataTemplateHolderCollection(),
                FrameworkPropertyMetadataOptions.Inherits));

        public static DataTemplateHolderCollection GetTemplates(UIElement element)
        {
            return element.GetValue(TemplatesProperty) as DataTemplateHolderCollection;
        }

        public static void SetTemplates(UIElement element, DataTemplateHolderCollection collection)
        {
            element.SetValue(TemplatesProperty, collection);
        }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (!(container is UIElement))
            {
                return base.SelectTemplate(item, container);
            }

            DataTemplateHolderCollection templates = GetTemplates(container as UIElement);
            if (templates == null || templates.Count == 0)
            {
                base.SelectTemplate(item, container);
            }

            foreach (DataTemplateHolder template in templates)
            {
                if (template.Value.IsInstanceOfType(item))
                {
                    return template.DataTemplate;
                }
            }

            return base.SelectTemplate(item, container);
        }
    }
}