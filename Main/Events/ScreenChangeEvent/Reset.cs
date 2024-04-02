using Main.Events.EmployeeEvent;
using Main.Events.OrderEvent;

namespace Main.Events.ScreenChangeEvent
{
#pragma warning disable IDE1006
    internal class ResetEvent
    {
        internal static void reset()
        {
            resetButton();
        }

        private static void resetButton()
        {
            EmployeeButtonClickEvent.editButtonIsEnable = false;
            OrderButtonClickEvent.editButtonIsEnable = false;
        }
    }
}
