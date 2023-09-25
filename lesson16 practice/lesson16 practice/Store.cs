using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace lesson16_practice
{
    internal class Store
    {
        public string Name { get; set; }
        public double Income { get; set; }
        public Phone[] phones = new Phone[0];



        public void AddPhone(Phone phone)
        {
            Array.Resize(ref phones, phones.Length + 1);
            phones[phones.Length - 1] = phone;

        }


        public string Sell(int id, int count)
        {
            foreach (Phone phone in phones)
            {
                if (phone.Id == id)
                {
                    if (count <= phone.Count_amount)
                    {
                        Income = Income + count * phone.Price;
                        phone.Count_amount = phone.Count_amount-count;
                        return $"{count} \"{phone.Name}\" named phones sold. {count * phone.Price} usd added to " +
                        $"income balance.";
                    }
                    else
                    {
                        return "Sorry! Not enough number of phones in the storage to sell.";
                    }
                }

            }

            return "Phone could not be found.";
        }



        public void ShowAllPhone()
        {
            foreach (Phone phone in phones)
            {
                phone.Show_Info();
            }
        }

        public void ShowPhoneForPrice(double min, double max)
        {
            foreach (Phone phone in phones)
            {
                if (phone.Price >= min && phone.Price <= max)
                {
                    phone.Show_Info();
                }
            }
        }



        public void Remove(int id)
        {
            Phone[] temp_phone = new Phone[0];

            foreach (Phone phone in phones)
            {
                if (phone.Id != id)
                {
                    Array.Resize(ref temp_phone, temp_phone.Length + 1);
                    temp_phone[temp_phone.Length - 1] = phone;
                }
            }

            phones = temp_phone;
        }


    }
}
