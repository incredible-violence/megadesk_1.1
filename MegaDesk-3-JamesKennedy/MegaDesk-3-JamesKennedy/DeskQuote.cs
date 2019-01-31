﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_JamesKennedy
{
    class DeskQuote
    {
        #region Object member variables
            private string CustomerName { get; set; }
            private DateTime QuoteDate = DateTime.Today;
            private Desk newDesk = new Desk();
            private int RushDays { get; set; }
            private int QuoteAmount = 0;
        #endregion

        #region local variables
        private int SurfaceArea = 0;

        #endregion

        #region constants
        private const int PRICE_BASE = 200;
        private const int SIZE_THRESHOLD = 1000;
        private const int PRICE_SURFACEAREA = 1;
        private const int PRICE_DRAWER = 50;
        #endregion
        public DeskQuote()
        {

        }

        public DeskQuote(int width, 
            int depth, int drawers, 
            string material, int rushDays, 
            string customer)
        {
            // variables from parameters
            newDesk.Width = width;
            newDesk.Depth = depth;
            newDesk.NumberOfDrawers = drawers;
            newDesk.DesktopMaterial = material;
            RushDays = rushDays;
            CustomerName = customer;
            
            // calculated variables
            SurfaceArea = newDesk.Width * newDesk.Depth;
            QuoteAmount = CalculateQuoteTotal(SurfaceArea, RushDays, newDesk.DesktopMaterial);
        }

        // aggregate costs into one number
        public int CalculateQuoteTotal(int surfaceArea, int rushDays, string deskMat)
        {
            return PRICE_BASE + DrawerCost() + SurfaceMaterialCost(deskMat) 
                + RushCost(surfaceArea, rushDays) + SurfaceAreaCost(surfaceArea);
        }

        // calculate cost of drawers
        private int DrawerCost()
        {
            return newDesk.NumberOfDrawers * PRICE_DRAWER; 
        }

        // calculate cost for surface material
        private int SurfaceMaterialCost(string mat)
        {
            switch (mat)
            {
                case "Oak":
                    return 200;
                case "Laminate":
                    return 100;
                case "Pine":
                    return 50;
                case "Rosewood":
                    return 300;
                case "Veneer":
                    return 125;
                default:
                    break;
            }
            return 1;
        }

        // Calculate Rush Cost
        private int RushCost(int surfaceArea, int days)
        {
            if (days == 3)
            {
                if (surfaceArea < 1000)
                {
                    return 60;
                }
                else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                {
                    return 70;
                }
                else if (surfaceArea > 2000)
                {
                    return 80;
                }
                else
                {
                    MessageBox.Show("How did you even do this", "CATASTROPHIC ERROR");
                }
            }
            else if (days == 5)
            {
                if (surfaceArea < 1000)
                {
                    return 40;
                }
                else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                {
                    return 50;
                }
                else if (surfaceArea > 2000)
                {
                    return 60;
                }
                else
                {
                    MessageBox.Show("How did you even do this", "CATASTROPHIC ERROR");
                }
            }
            else if (days == 7)
            {
                if (surfaceArea < 1000)
                {
                    return 30;
                }
                else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                {
                    return 35;
                }
                else if (surfaceArea > 2000)
                {
                    return 40;
                }
                else
                {
                    MessageBox.Show("How did you even do this", "CATASTROPHIC ERROR");
                }
            }
            return 1;
        }

        // calculate cost of surface area
        private int SurfaceAreaCost(int size)
        {
            if (size < 1000)
                return 0;
            else if (size > 1000)
                return size - 1000;
            else
                return 1;
        }
    }

    
}
