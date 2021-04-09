using Microsoft.AspNetCore.Components;

namespace BlazorSelect
{
    public interface ICloneable<T>{
        T Clone();
    }
    public class OptionData : ICloneable<OptionData> {
        public string label {get; set;}
        public object value {get; set;}
        public OptionData Clone(){
            return new OptionData(){label = label, value=value};
        }
    }

    public class CategorizedOption {
        public OptionData data {get; set;}
        public string label {get; set;}
        public object value {get; set;}
        public int index {get;set;}
        public bool isSelected {get; set;}
        public bool isDisabled {get; set;}
        public ElementReference reference { get; set; }
    }
    
}