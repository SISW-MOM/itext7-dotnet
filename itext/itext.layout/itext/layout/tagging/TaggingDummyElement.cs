using System;
using iText.Kernel.Pdf.Tagutils;
using iText.Layout;
using iText.Layout.Properties;

namespace iText.Layout.Tagging {
    public class TaggingDummyElement : IAccessibleElement, IPropertyContainer {
        private DefaultAccessibilityProperties properties;

        private Object id;

        public TaggingDummyElement(String role) {
            this.properties = new DefaultAccessibilityProperties(role);
        }

        public virtual AccessibilityProperties GetAccessibilityProperties() {
            return properties;
        }

        public virtual T1 GetProperty<T1>(int property) {
            if (property == Property.TAGGING_HINT_KEY) {
                return (T1)id;
            }
            return (T1)(Object)null;
        }

        public virtual void SetProperty(int property, Object value) {
            if (property == Property.TAGGING_HINT_KEY) {
                this.id = value;
            }
        }

        public virtual bool HasProperty(int property) {
            throw new NotSupportedException();
        }

        public virtual bool HasOwnProperty(int property) {
            throw new NotSupportedException();
        }

        public virtual T1 GetOwnProperty<T1>(int property) {
            throw new NotSupportedException();
        }

        public virtual T1 GetDefaultProperty<T1>(int property) {
            throw new NotSupportedException();
        }

        public virtual void DeleteOwnProperty(int property) {
            throw new NotSupportedException();
        }
    }
}