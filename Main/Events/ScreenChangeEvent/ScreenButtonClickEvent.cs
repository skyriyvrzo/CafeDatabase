using Main.Utils;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Main.Events.ScreenChangeEvent
{
#pragma warning disable IDE1006
    internal sealed class ScreenButtonClickEvent
    {
        /*
         *
         *
         *
         *
         */

        internal static void onClickEmployee(Form f)
        {
            f.Hide();
            Reference.employee = new Employee();
            Reference.employee.Show();
        }

        internal static void onClickOrder(Form f)
        {
            f.Hide();
            Reference.order = new Order();
            Reference.order.Show();
        }

        internal static void onClickDrink(Form f)
        {
            f.Hide();
            Reference.drink = new Drink();
            Reference.drink.Show();
        }

        internal static void onClickMaterial(Form f)
        {
            f.Hide();
            Reference.material = new Material();
            Reference.material.Show();
        }

        internal static void onClickTopping(Form f)
        {
            f.Hide();
            Reference.topping = new Topping();
            Reference.topping.Show();
        }

        internal static void onClickMaterialofDrink(Form f)
        {
            f.Hide();
            Reference.materialofDrink = new MaterialofDrink();
            Reference.materialofDrink.Show();
        }

        internal static void onClickOrderDetail(Form f)
        {
            f.Hide();
            Reference.orderDetail = new OrderDetail();
            Reference.orderDetail.Show();
        }
    }
}
