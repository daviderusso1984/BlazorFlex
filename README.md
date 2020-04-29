# BlazorFlex
 Blazorflex is a library for flexbox design for blazor

To Install

 Install-Package BlazorFlex
 
Or

 dotnet add package BlazorFlex

Use

BFlexbox implements many parameters
Direction => flex-direction
Vertical_align => align-items
Horizontal_aling => justify-content
Wrap => flex-wrap: wrap;

example:
```
<BFlexbox Direction="Directions.row" Horizontal_aling="Horizontal_alings.center" Vertical_align="Vertical_aligns.center" Wrap="true">
    <div>Testo</div>
    <div>Testo</div>
    <div>Testo</div>
    <div>Testo</div>
    <div>Testo</div>
    <div>Testo</div>
</BFlexbox>
```
