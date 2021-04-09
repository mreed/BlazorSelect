# BlazorSelect
Is a port of Jed Watson's ReactSelect to Blazor

Target Platform: .net 5

![Alt text](/ServerSample/wwwroot/sample_images/example2.png?raw=true "example of multi value dropdown")

![Alt text](/ServerSample/wwwroot/sample_images/example3.png?raw=true "example of single value dropdown")

## To Use in your Project:
- Blazor Server: Add services.AddBlazorStyled(); to Startup.cs under ConfigureServices 
- Blazor Client: Add builder.Services.AddBlazorStyled(); to Program Main

Add 

    <link href="_content/BlazorSelect/BlazorSelect.bundle.scp.css" rel="stylesheet"> 
    
## In _Host.cshtml or to index.html

Add 
`<script src="_content/BlazorSelect/BlazorSelect.js"></script>`


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
    [Parameter]
    public bool isMulti {get; set; } = false; // does component take multiple values



## Todo

- Add css classes for end users 
- Add all the events in reactselect
- Add all the parameters in reactselect
- Add placeholder
- Add scrollToView when selected option in dropdown changes
- Create Nuget Package



