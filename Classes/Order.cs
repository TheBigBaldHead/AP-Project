﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class Order
    {
        public int ID { get; set; }
        public string SenderAddress { get; set; }
        public string RecieverAddress { get; set; }
        public PackageContent Content { get; set; }
        public bool HasExpensiveContent { get; set; }
        public double Weight { get; set; }
        public PostType postType { get; set; }
        public string Phone { get; set; }
        public int OrderID { get; set; }
        public PackageStatus Status { get; set; }
        public string Comment { get; set; }
        /// <summary>
        /// محاسبه هزینه پست
        /// </summary>
        /// <returns></returns>
        public double Calculate()
        {
            double Fee = 10000;
            // handling content type
            double ContentFee = 0;
            if (Content == PackageContent.Object)
            {
                ContentFee = 0;
            }
            else if (Content == PackageContent.Document)
            {
                ContentFee = Fee * 0.5;
            }
            else if (Content == PackageContent.Breakable)
            {
                ContentFee = Fee;
            }
            // Check box for ExpensiveContent
            double ExpensiveContent = 0;
            if (HasExpensiveContent)
            {
                ExpensiveContent = Fee;
            }
            // hanling weight
            double WeightFee = 0;
            if (Weight > 0.5)
            {
                double weight = Weight;
                while (weight > 0.5)
                {
                    weight -= 0.5;
                    WeightFee += 0.2 * Fee;
                }
            }
            // handling post type
            double PostFee = 0;
            if (postType == PostType.Vanguard)
            {
                PostFee = Fee * 0.5;
            }
            return Fee + ContentFee + ExpensiveContent + WeightFee + PostFee;
        }

    }
}
