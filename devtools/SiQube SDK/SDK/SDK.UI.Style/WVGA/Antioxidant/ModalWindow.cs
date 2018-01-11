using System;

namespace SDK.UI.Widgets.Base // не менять с SDK.UI.Widgets.Base
{
    public partial class ModalWindow
    {
        public Action OnOkRelease;
        public Action OnYesRelease;
        public Action OnNoRelease;

        public string Message { get; set; }
        public string Header { get; set; }
    }
}
