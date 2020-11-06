/*
 * Author: Matthew Schwartz
 * Class: Menu.cs
 * Purpose: Class that represents the menu of Bleakwind Buffet
 */

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class that represents the menu of Bleakwind Buffet
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Property that represents each category of menu item
        /// </summary>
        public static string[] ItemCategory { get; } = { "Entree", "Drink", "Side" };

        /// <summary>
        /// Performs a search
        /// </summary>
        /// <param name="term">The searching term</param>
        /// <returns>A collection of IOrderItems that contain the searching term</returns>
        public static IEnumerable<IOrderItem> Search(string term)
        {
            if (term == null)
            {
                return FullMenu();
            }

            List<IOrderItem> results = new List<IOrderItem>();
            foreach(IOrderItem item in FullMenu())
            {
                if (item.ToString().ToLower().Contains(term.ToLower()))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters a search based on item category
        /// </summary>
        /// <param name="orderItems">Collection of items we are filtering on</param>
        /// <param name="categories">Collection of item categories we are filtering down to</param>
        /// <returns>A new collection of items that only includes items of type category</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> orderItems, IEnumerable<string> categories)
        {
            if (categories == null || categories.Count() == 0) return orderItems;

            List<IOrderItem> results = new List<IOrderItem>();
            foreach(IOrderItem item in orderItems)
            {
                if (item is Entree entree)
                {
                    if (categories.Contains("Entree")) results.Add(item);
                }
                else if (item is Drink drink)
                {
                    if (categories.Contains("Drink")) results.Add(item);
                }
                else if (item is Side side)
                {
                    if (categories.Contains("Side")) results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters order items based on calories
        /// </summary>
        /// <param name="orderItems">Collection of items we are filtering on</param>
        /// <param name="min">Minimum calorie count</param>
        /// <param name="max">Maximum calorie count</param>
        /// <returns>A new collection of items that all have a calorie count that falls between the min and max</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> orderItems, uint? min, uint? max)
        {
            if (min == null && max == null) return orderItems;

            List<IOrderItem> results = new List<IOrderItem>();
            if (min == null)
            {
                foreach(IOrderItem item in orderItems)
                {
                    if (item.Calories <= max) results.Add(item);
                }
            }
            
            if (max == null)
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item.Calories >= min) results.Add(item);
                }
            }

            foreach (IOrderItem item in orderItems)
            {
                if (item.Calories >= min && item.Calories <= max) results.Add(item);
            }
            return results;
        }

        /// <summary>
        /// Filters items based on price
        /// </summary>
        /// <param name="orderItems">Collection of items we are filering on</param>
        /// <param name="min">Minimum price</param>
        /// <param name="max">Maximum price</param>
        /// <returns>A new collection of items that all have a price that falls between the min and max</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> orderItems, double? min, double? max)
        {
            if (min == null && max == null) return orderItems;

            List<IOrderItem> results = new List<IOrderItem>();
            if (min == null)
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item.Price <= max) results.Add(item);
                }
            }

            if (max == null)
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item.Price >= min) results.Add(item);
                }
            }

            foreach (IOrderItem item in orderItems)
            {
                if (item.Price >= min && item.Price <= max) results.Add(item);
            }
            return results;
        }

        /// <summary>
        /// Creates a list of all the possible entrees.
        /// </summary>
        /// <returns>Returns a list of all the entree options</returns>
        public static List<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new GardenOrcOmelette());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new ThugsTBone());
            return entrees;
        }

        /// <summary>
        /// Creates a list of all the possible sides. Each side has small, medium, and large sizes.
        /// </summary>
        /// <returns>Returns a list of all the side options</returns>
        public static List<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            VokunSalad vS = new VokunSalad();
            vS.Size = Enums.Size.Small;
            VokunSalad vM = new VokunSalad();
            vM.Size = Enums.Size.Medium;
            VokunSalad vL = new VokunSalad();
            vL.Size = Enums.Size.Large;
            sides.Add(vS);
            sides.Add(vM);
            sides.Add(vL);

            DragonbornWaffleFries dS = new DragonbornWaffleFries();
            dS.Size = Enums.Size.Small;
            DragonbornWaffleFries dM = new DragonbornWaffleFries();
            dM.Size = Enums.Size.Medium;
            DragonbornWaffleFries dL = new DragonbornWaffleFries();
            dL.Size = Enums.Size.Large;
            sides.Add(dS);
            sides.Add(dM);
            sides.Add(dL);

            FriedMiraak fS = new FriedMiraak();
            fS.Size = Enums.Size.Small;
            FriedMiraak fM = new FriedMiraak();
            fM.Size = Enums.Size.Medium;
            FriedMiraak fL = new FriedMiraak();
            fL.Size = Enums.Size.Large;
            sides.Add(fS);
            sides.Add(fM);
            sides.Add(fL);

            MadOtarGrits mS = new MadOtarGrits();
            mS.Size = Enums.Size.Small;
            MadOtarGrits mM = new MadOtarGrits();
            mM.Size = Enums.Size.Medium;
            MadOtarGrits mL = new MadOtarGrits();
            mL.Size = Enums.Size.Large;
            sides.Add(mS);
            sides.Add(mM);
            sides.Add(mL);

            return sides;
        }

        /// <summary>
        /// Creates a list of all the possible drinks. Each drink has small, medium, and large sizes. 
        /// Each sailor soda has a small, medium, and large size for every flavor option.
        /// </summary>
        /// <returns>Returns a list of all the drink options</returns>
        public static List<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            AretinoAppleJuice aS = new AretinoAppleJuice();
            aS.Size = Enums.Size.Small;
            AretinoAppleJuice aM = new AretinoAppleJuice();
            aM.Size = Enums.Size.Medium;
            AretinoAppleJuice aL = new AretinoAppleJuice();
            aL.Size = Enums.Size.Large;
            drinks.Add(aS);
            drinks.Add(aM);
            drinks.Add(aL);

            CandlehearthCoffee cS = new CandlehearthCoffee();
            cS.Size = Enums.Size.Small;
            CandlehearthCoffee cM = new CandlehearthCoffee();
            cM.Size = Enums.Size.Medium;
            CandlehearthCoffee cL = new CandlehearthCoffee();
            cL.Size = Enums.Size.Large;
            drinks.Add(cS);
            drinks.Add(cM);
            drinks.Add(cL);

            MarkarthMilk mS = new MarkarthMilk();
            mS.Size = Enums.Size.Small;
            MarkarthMilk mM = new MarkarthMilk();
            mM.Size = Enums.Size.Medium;
            MarkarthMilk mL = new MarkarthMilk();
            mL.Size = Enums.Size.Large;
            drinks.Add(mS);
            drinks.Add(mM);
            drinks.Add(mL);

            WarriorWater wS = new WarriorWater();
            wS.Size = Enums.Size.Small;
            WarriorWater wM = new WarriorWater();
            wM.Size = Enums.Size.Medium;
            WarriorWater wL = new WarriorWater();
            wL.Size = Enums.Size.Large;
            drinks.Add(wS);
            drinks.Add(wM);
            drinks.Add(wL);

            SailorSoda sBlackberrySmall = new SailorSoda();
            sBlackberrySmall.Size = Enums.Size.Small;
            sBlackberrySmall.Flavor = Enums.SodaFlavor.Blackberry;
            SailorSoda sBlackberryMedium = new SailorSoda();
            sBlackberryMedium.Size = Enums.Size.Medium;
            sBlackberryMedium.Flavor = Enums.SodaFlavor.Blackberry;
            SailorSoda sBlackberryLarge = new SailorSoda();
            sBlackberryLarge.Size = Enums.Size.Large;
            sBlackberryLarge.Flavor = Enums.SodaFlavor.Blackberry;

            SailorSoda sCherrySmall = new SailorSoda();
            sCherrySmall.Size = Enums.Size.Small;
            sCherrySmall.Flavor = Enums.SodaFlavor.Cherry;
            SailorSoda sCherryMedium = new SailorSoda();
            sCherryMedium.Size = Enums.Size.Medium;
            sCherryMedium.Flavor = Enums.SodaFlavor.Cherry;
            SailorSoda sCherryLarge = new SailorSoda();
            sCherryLarge.Size = Enums.Size.Large;
            sCherryLarge.Flavor = Enums.SodaFlavor.Cherry;

            SailorSoda sGrapefruitSmall = new SailorSoda();
            sGrapefruitSmall.Size = Enums.Size.Small;
            sGrapefruitSmall.Flavor = Enums.SodaFlavor.Grapefruit;
            SailorSoda sGrapefruitMedium = new SailorSoda();
            sGrapefruitMedium.Size = Enums.Size.Medium;
            sGrapefruitMedium.Flavor = Enums.SodaFlavor.Grapefruit;
            SailorSoda sGrapefruitLarge = new SailorSoda();
            sGrapefruitLarge.Size = Enums.Size.Large;
            sGrapefruitLarge.Flavor = Enums.SodaFlavor.Grapefruit;

            SailorSoda sLemonSmall = new SailorSoda();
            sLemonSmall.Size = Enums.Size.Small;
            sLemonSmall.Flavor = Enums.SodaFlavor.Lemon;
            SailorSoda sLemonMedium = new SailorSoda();
            sLemonMedium.Size = Enums.Size.Medium;
            sLemonMedium.Flavor = Enums.SodaFlavor.Lemon;
            SailorSoda sLemonLarge = new SailorSoda();
            sLemonLarge.Size = Enums.Size.Large;
            sLemonLarge.Flavor = Enums.SodaFlavor.Lemon;

            SailorSoda sPeachSmall = new SailorSoda();
            sPeachSmall.Size = Enums.Size.Small;
            sPeachSmall.Flavor = Enums.SodaFlavor.Peach;
            SailorSoda sPeachMedium = new SailorSoda();
            sPeachMedium.Size = Enums.Size.Medium;
            sPeachMedium.Flavor = Enums.SodaFlavor.Peach;
            SailorSoda sPeachLarge = new SailorSoda();
            sPeachLarge.Size = Enums.Size.Large;
            sPeachLarge.Flavor = Enums.SodaFlavor.Peach;

            SailorSoda sWatermelonSmall = new SailorSoda();
            sWatermelonSmall.Size = Enums.Size.Small;
            sWatermelonSmall.Flavor = Enums.SodaFlavor.Watermelon;
            SailorSoda sWatermelonMedium = new SailorSoda();
            sWatermelonMedium.Size = Enums.Size.Medium;
            sWatermelonMedium.Flavor = Enums.SodaFlavor.Watermelon;
            SailorSoda sWatermelonLarge = new SailorSoda();
            sWatermelonLarge.Size = Enums.Size.Large;
            sWatermelonLarge.Flavor = Enums.SodaFlavor.Watermelon;

            drinks.Add(sBlackberrySmall);
            drinks.Add(sBlackberryMedium);
            drinks.Add(sBlackberryLarge);
            drinks.Add(sCherrySmall);
            drinks.Add(sCherryMedium);
            drinks.Add(sCherryLarge);
            drinks.Add(sGrapefruitSmall);
            drinks.Add(sGrapefruitMedium);
            drinks.Add(sGrapefruitLarge);
            drinks.Add(sLemonSmall);
            drinks.Add(sLemonMedium);
            drinks.Add(sLemonLarge);
            drinks.Add(sPeachSmall);
            drinks.Add(sPeachMedium);
            drinks.Add(sPeachLarge);
            drinks.Add(sWatermelonSmall);
            drinks.Add(sWatermelonMedium);
            drinks.Add(sWatermelonLarge);

            return drinks;
        }

        /// <summary>
        /// Creates a list of the full menu of Bleakwind Buffet
        /// </summary>
        /// <returns>Returns a list of the full menu, containing all options for entrees, sides, and drinks.
        /// Does not include special instructions options. </returns>
        public static List<IOrderItem> FullMenu()
        {
            List<IOrderItem> fullMenu = new List<IOrderItem>();
            fullMenu.Add(new BriarheartBurger());
            fullMenu.Add(new DoubleDraugr());
            fullMenu.Add(new GardenOrcOmelette());
            fullMenu.Add(new PhillyPoacher());
            fullMenu.Add(new SmokehouseSkeleton());
            fullMenu.Add(new ThalmorTriple());
            fullMenu.Add(new ThugsTBone());

            VokunSalad vS = new VokunSalad();
            vS.Size = Enums.Size.Small;
            VokunSalad vM = new VokunSalad();
            vM.Size = Enums.Size.Medium;
            VokunSalad vL = new VokunSalad();
            vL.Size = Enums.Size.Large;
            fullMenu.Add(vS);
            fullMenu.Add(vM);
            fullMenu.Add(vL);

            DragonbornWaffleFries dS = new DragonbornWaffleFries();
            dS.Size = Enums.Size.Small;
            DragonbornWaffleFries dM = new DragonbornWaffleFries();
            dM.Size = Enums.Size.Medium;
            DragonbornWaffleFries dL = new DragonbornWaffleFries();
            dL.Size = Enums.Size.Large;
            fullMenu.Add(dS);
            fullMenu.Add(dM);
            fullMenu.Add(dL);

            FriedMiraak fS = new FriedMiraak();
            fS.Size = Enums.Size.Small;
            FriedMiraak fM = new FriedMiraak();
            fM.Size = Enums.Size.Medium;
            FriedMiraak fL = new FriedMiraak();
            fL.Size = Enums.Size.Large;
            fullMenu.Add(fS);
            fullMenu.Add(fM);
            fullMenu.Add(fL);

            MadOtarGrits mogS = new MadOtarGrits();
            mogS.Size = Enums.Size.Small;
            MadOtarGrits mogM = new MadOtarGrits();
            mogM.Size = Enums.Size.Medium;
            MadOtarGrits mogL = new MadOtarGrits();
            mogL.Size = Enums.Size.Large;
            fullMenu.Add(mogS);
            fullMenu.Add(mogM);
            fullMenu.Add(mogL);

            AretinoAppleJuice aS = new AretinoAppleJuice();
            aS.Size = Enums.Size.Small;
            AretinoAppleJuice aM = new AretinoAppleJuice();
            aM.Size = Enums.Size.Medium;
            AretinoAppleJuice aL = new AretinoAppleJuice();
            aL.Size = Enums.Size.Large;
            fullMenu.Add(aS);
            fullMenu.Add(aM);
            fullMenu.Add(aL);

            CandlehearthCoffee cS = new CandlehearthCoffee();
            cS.Size = Enums.Size.Small;
            CandlehearthCoffee cM = new CandlehearthCoffee();
            cM.Size = Enums.Size.Medium;
            CandlehearthCoffee cL = new CandlehearthCoffee();
            cL.Size = Enums.Size.Large;
            fullMenu.Add(cS);
            fullMenu.Add(cM);
            fullMenu.Add(cL);

            MarkarthMilk mS = new MarkarthMilk();
            mS.Size = Enums.Size.Small;
            MarkarthMilk mM = new MarkarthMilk();
            mM.Size = Enums.Size.Medium;
            MarkarthMilk mL = new MarkarthMilk();
            mL.Size = Enums.Size.Large;
            fullMenu.Add(mS);
            fullMenu.Add(mM);
            fullMenu.Add(mL);

            WarriorWater wS = new WarriorWater();
            wS.Size = Enums.Size.Small;
            WarriorWater wM = new WarriorWater();
            wM.Size = Enums.Size.Medium;
            WarriorWater wL = new WarriorWater();
            wL.Size = Enums.Size.Large;
            fullMenu.Add(wS);
            fullMenu.Add(wM);
            fullMenu.Add(wL);

            SailorSoda sBlackberrySmall = new SailorSoda();
            sBlackberrySmall.Size = Enums.Size.Small;
            sBlackberrySmall.Flavor = Enums.SodaFlavor.Blackberry;
            SailorSoda sBlackberryMedium = new SailorSoda();
            sBlackberryMedium.Size = Enums.Size.Medium;
            sBlackberryMedium.Flavor = Enums.SodaFlavor.Blackberry;
            SailorSoda sBlackberryLarge = new SailorSoda();
            sBlackberryLarge.Size = Enums.Size.Large;
            sBlackberryLarge.Flavor = Enums.SodaFlavor.Blackberry;

            SailorSoda sCherrySmall = new SailorSoda();
            sCherrySmall.Size = Enums.Size.Small;
            sCherrySmall.Flavor = Enums.SodaFlavor.Cherry;
            SailorSoda sCherryMedium = new SailorSoda();
            sCherryMedium.Size = Enums.Size.Medium;
            sCherryMedium.Flavor = Enums.SodaFlavor.Cherry;
            SailorSoda sCherryLarge = new SailorSoda();
            sCherryLarge.Size = Enums.Size.Large;
            sCherryLarge.Flavor = Enums.SodaFlavor.Cherry;

            SailorSoda sGrapefruitSmall = new SailorSoda();
            sGrapefruitSmall.Size = Enums.Size.Small;
            sGrapefruitSmall.Flavor = Enums.SodaFlavor.Grapefruit;
            SailorSoda sGrapefruitMedium = new SailorSoda();
            sGrapefruitMedium.Size = Enums.Size.Medium;
            sGrapefruitMedium.Flavor = Enums.SodaFlavor.Grapefruit;
            SailorSoda sGrapefruitLarge = new SailorSoda();
            sGrapefruitLarge.Size = Enums.Size.Large;
            sGrapefruitLarge.Flavor = Enums.SodaFlavor.Grapefruit;

            SailorSoda sLemonSmall = new SailorSoda();
            sLemonSmall.Size = Enums.Size.Small;
            sLemonSmall.Flavor = Enums.SodaFlavor.Lemon;
            SailorSoda sLemonMedium = new SailorSoda();
            sLemonMedium.Size = Enums.Size.Medium;
            sLemonMedium.Flavor = Enums.SodaFlavor.Lemon;
            SailorSoda sLemonLarge = new SailorSoda();
            sLemonLarge.Size = Enums.Size.Large;
            sLemonLarge.Flavor = Enums.SodaFlavor.Lemon;

            SailorSoda sPeachSmall = new SailorSoda();
            sPeachSmall.Size = Enums.Size.Small;
            sPeachSmall.Flavor = Enums.SodaFlavor.Peach;
            SailorSoda sPeachMedium = new SailorSoda();
            sPeachMedium.Size = Enums.Size.Medium;
            sPeachMedium.Flavor = Enums.SodaFlavor.Peach;
            SailorSoda sPeachLarge = new SailorSoda();
            sPeachLarge.Size = Enums.Size.Large;
            sPeachLarge.Flavor = Enums.SodaFlavor.Peach;

            SailorSoda sWatermelonSmall = new SailorSoda();
            sWatermelonSmall.Size = Enums.Size.Small;
            sWatermelonSmall.Flavor = Enums.SodaFlavor.Watermelon;
            SailorSoda sWatermelonMedium = new SailorSoda();
            sWatermelonMedium.Size = Enums.Size.Medium;
            sWatermelonMedium.Flavor = Enums.SodaFlavor.Watermelon;
            SailorSoda sWatermelonLarge = new SailorSoda();
            sWatermelonLarge.Size = Enums.Size.Large;
            sWatermelonLarge.Flavor = Enums.SodaFlavor.Watermelon;

            fullMenu.Add(sBlackberrySmall);
            fullMenu.Add(sBlackberryMedium);
            fullMenu.Add(sBlackberryLarge);
            fullMenu.Add(sCherrySmall);
            fullMenu.Add(sCherryMedium);
            fullMenu.Add(sCherryLarge);
            fullMenu.Add(sGrapefruitSmall);
            fullMenu.Add(sGrapefruitMedium);
            fullMenu.Add(sGrapefruitLarge);
            fullMenu.Add(sLemonSmall);
            fullMenu.Add(sLemonMedium);
            fullMenu.Add(sLemonLarge);
            fullMenu.Add(sPeachSmall);
            fullMenu.Add(sPeachMedium);
            fullMenu.Add(sPeachLarge);
            fullMenu.Add(sWatermelonSmall);
            fullMenu.Add(sWatermelonMedium);
            fullMenu.Add(sWatermelonLarge);
            return fullMenu;
        }
    }
}
