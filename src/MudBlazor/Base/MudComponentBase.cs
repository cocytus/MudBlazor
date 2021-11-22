using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace MudBlazor
{
    public abstract class MudComponentBase : ComponentBase
    {
        /// <summary>
        /// User class names, separated by space.
        /// </summary>
        [Parameter] public string Class { get; set; }

        /// <summary>
        /// User styles, applied on top of the component's own classes and styles.
        /// </summary>
        [Parameter] public string Style { get; set; }

        /// <summary>
        /// Use Tag to attach any user data object to the component for your convenience.
        /// </summary>
        [Parameter] public object Tag { get; set; }

        [Parameter]
        public Dictionary<string, object> UserAttributes { get; set; } = new Dictionary<string, object>();
    }
}
