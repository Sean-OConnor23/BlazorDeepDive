Notes Taken During Udemy Course:
-Section 2: Blazor SSR (Static Site Rendering)
  - Start of program: Program.cs --> App.razor --> Routes.razor --> MainLayout.razor
  - Static Components (images, bootstrap, etc.) should be located under wwwroot folder
  - Static data repositories --> under Models folder
  - Routable Components --> Pages folder
  - Non-Routable Components --> Controls folder
       - Can be called via HTML tag
       - Ensure it is referenced in _Imports file
  - We can include route parameters on pages using {variable} in the @page tag
      - If we want the paramater to be optional we use a "?" Ex. @page "/example/{text?}"
      - In addition, we have to create a variable in @code with [Parameter] above it as an identifier
  - OnParametersSet() is triggered whenever the page receives parameters from its parent in the render tree
  - Microsoft provides a built-in component for forms --> <EditForm>
      - and built-in inputs: <input/> --> <InputText>, <InputNumber>, <InputCheckbox>
      - Use Model attribute tag to define what type of data we are working with
      - @bind-Value to link input to specific value/variable
      - Each form must have a FormName="" and OnSubmit="function" (function is defined in @code)
      - To submit data back, must have a [SupplyParameterFromForm(FormName="")] attribute to link back in @code
      - Have a button of type="submit" somewhere within the form
      - To pass data not wanting to display in form, use hidden attribute
          - Example: <InputNumber bind-Value="" hidden></InputNumber>
  - Form submission is different for SSR than a Blazor Web App with interactivity
  - ?? after variable means assignment if the variable is null. Will not do anything if it is not null
  - [Required] above any variable declares it as required in form
      - Comes from System.ComponentModel.DataAnnotations
  - To validate data in the form there are a couple options (Use OnValidSubmit instead of OnSubmit)
      - < DataAnnotationsValidator>
      - < ValidationSummary>
      - < ValidationMessage>
        - Use For="() => server.Name" to specificy which variable the validator is checking
  - NavigationManager has to be inserted via dependency injection
  - Injection is performed via @inject
      - keeps us from having to instantiate objects and reduces unnecessary dependencies
      - simplifies life cyle of dependencies in components (using DI container)
      - DI container defined in Program.cs (builder.Services.AddRazorComponents())
  - When deleting and SSR, need to use an HTTPS POST functionality such as <EditForm>
      - Don't use <a> because the history will be stored in the browser
  - Stream Rendering allows for the view to be rendered and partial of it to be rendered later
      - Have to use @attribute [StreamRendering] at top of Routable Component file
      - Reference weather.razor in example code
      - The to be loaded aspect must not be static
- Section 3: Server Interactivity
  - User --> DOM (document object model) --> JS (blazor.web.js) --> Web Server and then reverse back to user patching what needs to be updated on browser
  - Enhanced Navigation is enabled in Blazor Web App by default
      - via blazor.web.js
      - first step toward interactivity
  - When an application as able to partially render, we can consider that interactive
  - Enhanced Form Handling
      - To keep whole page from being refreshed when using <EditForm> we must enhance.
      - Example: < EditForm Enhance="true">
  
