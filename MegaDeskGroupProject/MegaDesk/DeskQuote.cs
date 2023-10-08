using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk
{
    public class DeskQuote
    {
        public Desk Desk { get; set; }
        public string Name { get; set; }
        public string OrderDate { get; set; }
        public double RushOrder {  get; set; }
        public double Price { get; set; }
        public double Depth { get { return Desk.Depth; } }
        public double Width { get{ return Desk.Width; } }
        public double NumberofDrawers { get { return Desk.NumberofDrawers; } }
        public SurfaceMaterial SurfaceMaterial { get { return Desk.SurfaceMaterial; } }

        public double surfaceArea = 0;
        public double totalSurfaceArea = 0;
        public double addDrawer = 0;

        private const double BasePrice = 200;
        private const double PriceDrawer = 50;
        private const double PriceOak = 200;
        private const double PriceLaminate = 100;
        private const double PriceRosewood = 300;
        private const double PriceVeneer = 125;
        private const double PricePine = 50;
        private const double ExtraSurfaceArea = 1;

        private double[,] rushOrderData;
        const string rushfilePath = "rushOrderPrices.txt";

        public DeskQuote(Desk desk) 
        {
            Desk = desk;
            GetOrderDate();
            rushOrderData = new double[3, 3];
        }

        public void GetOrderDate()
        {
            DateTime dateTime = DateTime.Now;
            OrderDate = dateTime.ToString("MM/dd/yyyy");
        }

        //GetPrice Function
        public double GetPrice()
        {
            double deskPrice = 0;
            surfaceArea = Width * Depth;
            
            if (surfaceArea>1000)
            {
                totalSurfaceArea = (surfaceArea - 1000) * ExtraSurfaceArea + BasePrice; 
            }
            else
                { totalSurfaceArea = BasePrice; }
            
            if (NumberofDrawers>0)
            {
                addDrawer = NumberofDrawers * PriceDrawer;
            }
            else
            { addDrawer = 0; }

            double surfaceCost = 0;
            switch (SurfaceMaterial)
            {
                case SurfaceMaterial.oak:
                    {
                        surfaceCost= PriceOak;
                        break;
                    }
                case SurfaceMaterial.laminate:
                    {
                        surfaceCost = PriceLaminate;
                        break;
                    }
                case SurfaceMaterial.rosewood:
                    {
                        surfaceCost = PriceRosewood;
                        break;
                    }
                case SurfaceMaterial.veneer:
                    {
                        surfaceCost = PriceVeneer;
                        break;
                    }
                case SurfaceMaterial.pine:
                    {
                        surfaceCost = PricePine;
                        break;
                    }
            }
            double rushCost = GetRush();
            deskPrice = totalSurfaceArea + addDrawer + rushCost + surfaceCost;
            Price = deskPrice;
            return deskPrice;
        }

        public double GetRush()
        {
            int colIndex = -1;
            int rowIndex = -1;
            switch (RushOrder)
            {
                case 3:
                    rowIndex = 0;
                    if (totalSurfaceArea < 1000)
                    {
                        colIndex = 0;
                    }

                    else if (totalSurfaceArea > 1000 && totalSurfaceArea < 2000)
                    {
                        colIndex = 1;
                    }
                    else
                    {
                        colIndex = 2;
                    }
                    return GetRushOrder(rowIndex,colIndex);
                        
                case 5:
                    rowIndex = 1;
                    if (totalSurfaceArea < 1000)
                    {
                        colIndex = 0;
                    }

                    else if (totalSurfaceArea > 1000 && totalSurfaceArea < 2000)
                    {
                        colIndex = 1;
                    }
                    else
                    {
                        colIndex = 2;
                    }
                    return GetRushOrder(rowIndex, colIndex);

                case 7:
                    rowIndex = 2;
                    if (totalSurfaceArea < 1000)
                    {
                        colIndex = 0;
                    }

                    else if (totalSurfaceArea > 1000 && totalSurfaceArea < 2000)
                    {
                        colIndex = 01;
                    }
                    else
                    {
                        colIndex = 01;
                    }
                    return GetRushOrder(rowIndex, colIndex);
                default:
                    return  0;
            }
        }

        //Group - Amanda add GetRushOrder method to create array and pull data from rushOrderPrices.txt
        //sets variables for rush

        public double GetRushOrder(int rowIndex, int colIndex)
        {
            double[,] values = new double[3, 3];
            try
            {
                string[] lines = File.ReadAllLines(rushfilePath, Encoding.UTF8);

                int index = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        values[i, j] = double.Parse(lines[index]);
                        index++;
                    }
                }
                return values[rowIndex, colIndex];
            }
            catch (Exception)
            {
                MessageBox.Show("Rush File Not Found");
                return 0;
            }
        }

    }
}
