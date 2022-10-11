﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace XIV.Utils
{
    /// <summary>
    /// Utilities for <see cref="Form"/> class
    /// </summary>
    public static class FormUtils
    {
        /// <summary>
        /// Close all forms but keep the ones that has same type with <typeparamref name="T"/>
        /// </summary>
        public static void CloseAllBut<T>() where T : Form
        {
            Type type = typeof(T);
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() != type)
                {
                    form.Close();
                }
                else
                {
                    form.Show();
                    form.Activate();
                }
            }
        }

        /// <summary>
        /// Close all Forms type of <typeparamref name="T"/>
        /// </summary>
        public static void CloseAllInstance<T>() where T : Form
        {
            Type type = typeof(T);
            foreach (Form item in Application.OpenForms)
            {
                if(item.GetType() != type)
                {
                    item.Close();
                }
            }
        }

        /// <summary>
        /// If any <typeparamref name="T"/> type form is open, 
        /// sets <paramref name="form"/> value as giving type and returns true
        /// </summary>
        /// <typeparam name="T">Form Type</typeparam>
        /// <param name="form">null if form is not open</param>
        /// <returns>True if form is open</returns>
        public static bool GetForm<T>(out T form) where T : Form
        {
            Type type = typeof(T);
            form = null;
            foreach (Form item in Application.OpenForms)
            {
                if(item.GetType() == type)
                {
                    form = (T)item;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// If form is open returns form, else returns new form of type <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Form Type</typeparam>
        public static T OpenForm<T>(Form mdiParent, bool show = true) where T : Form
        {
            if(GetForm<T>(out T form))
            {
                form.MdiParent = mdiParent;
                if (show)
                {
                    form.Show();
                    //TODO : Do we need Activate call?
                    form.Activate();
                }
                return form;
            }
            form = CreateForm<T>();
            form.MdiParent = mdiParent;
            if (show)
            {
                form.Show();
                //TODO : Do we need Activate call?
                form.Activate();
            }
            return form;
        }

        /// <summary>
        /// Creates a form type of <typeparamref name="T"/>
        /// </summary>
        public static T CreateForm<T>() where T : Form
        {
            return (T)Activator.CreateInstance(typeof(T));
        }

        //TODO : Add ability to exclude specified control instances or control types
        /// <summary>
        /// Gets all controls of type <typeparamref name="T"/> from <paramref name="form"/> 
        /// and sets size of all with giving <paramref name="size"/>
        /// </summary>
        /// <typeparam name="T">Type of Control</typeparam>
        /// <param name="size">New size of <typeparamref name="T"/></param>
        /// <param name="form">Get controls from <paramref name="form"/></param>
        public static void SetSizeOfType<T>(Size size, Form form) where T : Control
        {
            List<T> controls = GetControlsOfType<T>(form);
            for (int i = 0; i < controls.Count; i++)
            {
                controls[i].Size = size;
            }
        }

        /// <typeparam name="T">Type of Control</typeparam>
        /// <param name="form">Get controls from <paramref name="form"/></param>
        /// <returns>A List that contains of type <typeparamref name="T"/></returns>
        public static List<T> GetControlsOfType<T>(Form form) where T : Control
        {
            List<T> controlList = new List<T>();
            Type controlType = typeof(T);
            for (int i = 0; i < form.Controls.Count; i++)
            {
                if (form.Controls[i].GetType() == controlType)
                {
                    controlList.Add((T)form.Controls[i]);
                }
            }
            return controlList;
        }

    }

}