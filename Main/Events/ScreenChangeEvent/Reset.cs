using Main.Events.DrinkEvent;
using Main.Events.EmployeeEvent;
using Main.Events.MaterialEvent;
using Main.Events.MaterialofDrinkEvent;
using Main.Events.OrderEvent;
using Main.Events.ToppingEvent;

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
            MaterialButtonClickEvent.editButtonIsEnable = false;
            ToppingButtonClickEvent.editButtonIsEnable = false;
            DrinkButtonClickEvent.editButtonIsEnable = false;
            MaterialofDrinkButtonClickEvent.editButtonIsEnable = false;
        }
    }
}
