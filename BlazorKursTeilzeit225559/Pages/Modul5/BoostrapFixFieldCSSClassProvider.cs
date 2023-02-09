using Microsoft.AspNetCore.Components.Forms;

namespace BlazorKursTeilzeit225559.Pages.Modul5
{
    public class BoostrapFixFieldCSSClassProvider : FieldCssClassProvider
    {
        public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier)
        {
          var isinvalid=  editContext.GetValidationMessages(fieldIdentifier).Any();
            return isinvalid?"is-invalid":"is-valid";
        }
    }
}
