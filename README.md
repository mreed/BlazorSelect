# BlazorSelect
Is a port of Jed Watson's ReactSelect to Blazor

## To Use in your Project:
- Blazor Server: Add services.AddBlazorStyled(); to Startup.cs under ConfigureServies 
- Blazor Client: Add builder.Services.AddBlazorStyled(); to Program Main

Add 

    <link href="_content/BlazorSelect/BlazorSelect.bundle.scp.css" rel="stylesheet"> 
    
to _Host.cshtml or to index

Add <script src="_content/BlazorSelect/BlazorSelect.js"></script> to _Host.cshtml or to index


## To Use
- Declare the component:
    
    `<BlazorSelect.Select isMulti="true" OnChange="@MyChangeFunction" selectValues="@values" options="@options"   />`


## Parameters
    [Parameter]
    public bool? clearable { get; set; } = true; //can user clear all selected values
    [Parameter]
    public bool clearInputAfterSelect { get; set; } = true; //after user selected a value should it clear the current search input
    [Parameter]
    public List<OptionData> options { get; set; } //the list of options, OptionData has string label and object value
    [Parameter]
    public EventCallback<List<OptionData>> OnChange { get; set; } returns new values should be declared as MyChangeFunction(List<OptionData>)
    [Parameter]
    public List<OptionData> selectValues { get; set; } //currently selected values is  List<OptionData>
    [Parameter]
    public bool isDisabled { get; set; } = false; // is component disabled



## Todo

- Add css classes for end users 
- Add all the events in reactselect
- Add all the parameters in reactselect
- Create Nuget Package



