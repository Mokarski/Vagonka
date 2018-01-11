using SDK.UI.Widgets.Base;

namespace SDK.UI.Widgets.Interfaces
{
    public interface IWindow : IWidget
    {
        void AddModal(ModalWindow modalWindow);
        Color Background { get; set; }
    }

    public delegate void UserChooseEvent(string eventId);
    public interface IModalWindow : IWidget
    {        
        //event UserChooseEvent OnCustomerEvent;
    }

    public class ModalButtons
    {
        public static string Ok = "Ok";
        public static string Cancel = "Cancel";
        public static string Yes = "Yes";
        public static string No = "No";
    }
    
    /*
    var wnd = new ClassicWindow("myWnd");
    var modalWnd = new MyModalWindow("myModalWnd");
    wnd.AddModal(modalWnd);

    modalWnd.OnCustomerEvent += eventId =>
                {
            
                    switch(eventId)
                    {
                        case ModalButtons.Ok:
                        {
    
                        }
                        break;

                        case "user.modal.unique.event":
                        {
    
                        }
                        break;
                    }
                };
    */
}