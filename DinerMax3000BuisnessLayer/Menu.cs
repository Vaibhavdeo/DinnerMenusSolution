using System;
using System.Collections.Generic;
using System.Text;
using DinnerMax3000.Business.dsDinnerMax3000TableAdapters;

namespace DinnerMax3000.Business
{
    public class Menu
    {
        public Menu()
        {
            items = new List<MenuItem>();
        }

        public static List<Menu> GetAllMenus()
        {
            MenuTableAdapter taMenu = new MenuTableAdapter();
            MenuItemTableAdapter taMenuItem = new MenuItemTableAdapter();
            var dtMenu = taMenu.GetData();
            List<Menu> allMenus = new List<Menu>();
            foreach (dsDinnerMax3000.MenuRow menuRow in dtMenu.Rows)
            {
                Menu currentMenu = new Menu();
                currentMenu.name = menuRow.name;
                allMenus.Add(currentMenu);

                var dtMenuItems = taMenuItem.GetMenuItemByMenuId(menuRow.Id);

                foreach(dsDinnerMax3000.MenuItemDataTable menuItemRow in dtMenuItems.Rows)
                {
                    currentMenu.AddMenuItem(menuItemRow.Name, menuItemRow.Description, menuItemRow.Price);
                }
            }

            return allMenus;


        }
        public string name { get; set; }
        public List<MenuItem> items { get; set; }

        public void AddMenuItem(string Title, string description, double price)
        {
            MenuItem menuItem = new MenuItem();
            menuItem.Title = Title;
            menuItem.Description = description;
            menuItem.Price = price;
        }
    }
}
