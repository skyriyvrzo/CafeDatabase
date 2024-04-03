using CSharp.Util.Logging;
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
            onChange(f, Reference.employee);
        }

        internal static void onClickOrder(Form f)
        {
            f.Hide();
            Reference.order = new Order();
            Reference.order.Show();
            onChange(f, Reference.order);
        }

        internal static void onClickDrink(Form f)
        {
            f.Hide();
            Reference.drink = new Drink();
            Reference.drink.Show();
            onChange(f, Reference.drink);
        }

        internal static void onClickMaterial(Form f)
        {
            f.Hide();
            Reference.material = new Material();
            Reference.material.Show();
            onChange(f, Reference.material);
        }

        internal static void onClickTopping(Form f)
        {
            f.Hide();
            Reference.topping = new Topping();
            Reference.topping.Show();
            onChange(f, Reference.topping);
        }

        internal static void onClickMaterialofDrink(Form f)
        {
            f.Hide();
            Reference.materialofDrink = new MaterialofDrink();
            Reference.materialofDrink.Show();
            onChange(f, Reference.materialofDrink);
        }

        internal static void onClickOrderDetail(Form f)
        {
            f.Hide();
            Reference.orderDetail = new OrderDetail();
            Reference.orderDetail.Show();
            onChange(f, Reference.orderDetail);
        }

        private static void onChange(Form from, Form to)
        {
            Program.logger.Log(Level.INFO, nameof(onChange), nameof(ScreenChangeEvent), from.Name + " -> " + to.Name);
        }
    }
}
