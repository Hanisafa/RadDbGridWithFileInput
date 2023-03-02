using Microsoft.AspNetCore.Components.Forms;

public class MyUploadViewModel
{
      public IBrowserFile? FileToUpload { get; set; }
      public string Description {get;set;}
}