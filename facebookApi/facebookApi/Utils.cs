using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace facebookApi
{
    public static class Utils
    {
        private const int k_CheckBoxLocationX = 6;
        private const int k_CheckBoxLocationYStart = 21;
        private const int k_CheckBoxLocationYDiff = 23;

        /// <summary>
        /// Add or remove values from a list according to a CheckBox value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="i_CheckBox"></param>
        /// <param name="i_SetToEdit"></param>
        public static void CheckBoxChanged<T>(CheckBox i_CheckBox, ISet<T> i_SetToEdit) where T : struct, System.IConvertible
        {
            T value = (T)Enum.Parse(typeof(T), i_CheckBox.Text);

            if (i_CheckBox.Checked)
            {
                i_SetToEdit.Add(value);
            }
            else
            {
                i_SetToEdit.Remove(value);
            }
        }

        /// <summary>
        /// Generate a CheckBox and add it to a GroupBox
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="i_CheckBoxValues"></param>
        /// <param name="i_GroupBox"></param>
        /// <param name="i_EventHandler"></param>
        public static void GenerateCheckBoxesAndAddToGroupBox<T>(List<T> i_CheckBoxValues, GroupBox i_GroupBox, EventHandler i_EventHandler) where T : struct, System.IConvertible
        {
            int i = 0;

            foreach (T value in i_CheckBoxValues)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.AutoSize = true;
                checkBox.Location = new Point(k_CheckBoxLocationX, k_CheckBoxLocationYStart + (i * k_CheckBoxLocationYDiff));
                checkBox.Name = value.ToString();
                checkBox.TabIndex = i + 1;
                checkBox.Text = value.ToString();
                checkBox.UseVisualStyleBackColor = true;
                checkBox.CheckedChanged += i_EventHandler;
                i_GroupBox.Controls.Add(checkBox);
                i++;
            } 
        }

        /// <summary>
        /// Get a set of filtered users according to the filter set and filter helper
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="i_UsersToFilter"></param>
        /// <param name="i_FilterSet"></param>
        /// <param name="i_UserFilterHelper"></param>
        /// <returns>A set of users that match the filter</returns>
        public static ISet<User> GetFilteredUsers<T>(List<User> i_UsersToFilter, ISet<T> i_FilterSet, IUserFilterHelper<T> i_UserFilterHelper) where T : struct, System.IConvertible
        {
            ISet<User> filteredUsers = new HashSet<User>();

            foreach (User user in i_UsersToFilter)
            {
                if (i_FilterSet.Count == 0)
                {
                    filteredUsers.Add(user);
                }
                else
                {
                    foreach (T filter in i_FilterSet)
                    {
                        if (i_UserFilterHelper.FilterApplies(user, filter))
                        {
                            filteredUsers.Add(user);
                        }
                    }
                }
            }

            return filteredUsers;
        }
    }
}
