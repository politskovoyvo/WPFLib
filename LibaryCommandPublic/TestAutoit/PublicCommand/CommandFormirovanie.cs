﻿using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using LibaryXMLAuto.Converts.ConvettToXml;
using ViewModelLib.ModelTestAutoit.ModelFormirovanie.CheckBoxModel;
using ViewModelLib.ModelTestAutoit.ModelFormirovanie.ListViewModelXml;
using ViewModelLib.ModelTestAutoit.ModelFormirovanie.ShemeXsd;
using ViewModelLib.ModelTestAutoit.ModelFormirovanie.StackPanelModel.ShemeSnuOneForm;
using ViewModelLib.ModelTestAutoit.ModelFormirovanie.TextBoxModel;

namespace LibaryCommandPublic.TestAutoit.SnuOneAuto.PublicCommand
{
   /// <summary>
   /// Библиотека для команд связана с библиотекой AddModelProject
   /// т.к. некоторые модели чтобы заполнить требуется логика выбора
   /// </summary>
   public class CommandFormirovanie
    {
        /// <summary>
        /// Команда Выбрать файл дальше направлям файл в коллекцию для дальнейшего разбора
        /// </summary>
        /// <param name="modelTextBox">Модель modelTextBox</param>
        /// <param name="modelSnuOne">Модель modelSnuOne</param>
        public void SelectFileSlsx(TextBoxModelMethod modelTextBox, ModelSnuOneFormNameListMethod modelSnuOne)
        {
            var dialog = new PublicLogicaFull.FileLogica.DialogWindowSelect.DialogFileSelect();
            var file = dialog.OpenFileDialog();
            if (file!=null)
            {
                modelTextBox.NewFileXsls(file);
                modelSnuOne.AddParseXsls(file);
            }
        }
        /// <summary>
        /// Формирование списков xml по схеме!!! 
        /// </summary>
        /// <param name="modelsnuone">Выбор модели Сериализации файла</param>
        /// <param name="textboxfilemodel">Модель файла</param>
        /// <param name="shemedocument">Модель схем</param>
        /// <param name="checkBoxModel">Модель заголовка</param>
        /// <param name="path">Путь сохранение xml</param>
        /// <param name="xmlmodel">ListView для отражения xml</param>
        public void  FormirovanieXml(ModelSnuOneFormNameListProperty modelsnuone, TextBoxModelMethod textboxfilemodel,ShemeMethod shemedocument, CheckBoxModel checkBoxModel,string path, ListViewModelXmlFileGenerateMethod xmlmodel)
        {
                    XmlConvert convert = new XmlConvert();
            if (shemedocument.IsValidation())
            {
                switch (shemedocument.Shema.Shemes)
                {
                    case "SnuOneForm":
                        if (textboxfilemodel.IsValidation() && modelsnuone.IsValidation())
                        {
                            xmlmodel.UpdateOn();
                            Task.Run((delegate
                            {
                                try
                                {
                                    convert.ConvertListSnuOneForm(textboxfilemodel.Path,
                                        modelsnuone.SelectList.Listletter,
                                        modelsnuone.SelectColumnLetter.ColumnName, checkBoxModel.IsCheced, path);
                                    xmlmodel.AddXmlFile(path);
                                    xmlmodel.UpdateOff();
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }));
                        }
                        break;
                    case "TreatmentFpd":
                        if (textboxfilemodel.IsValidation() && modelsnuone.IsValidation() && checkBoxModel.IsValidation())
                        {
                            xmlmodel.UpdateOn();
                            Task.Run((delegate
                            {
                                try
                                {
                                    convert.ConvertListFpdReg(textboxfilemodel.Path, modelsnuone.SelectList.Listletter,
                                        modelsnuone.SelectColumnLetter.ColumnName, checkBoxModel.SelectIntRow, path);
                                    xmlmodel.AddXmlFile(path);
                                    xmlmodel.UpdateOff();
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }));
                        }
                        break;
                    case "FullInnCount":
                        if (textboxfilemodel.IsValidation() && modelsnuone.IsValidation() &&checkBoxModel.IsValidation())
                        {
                            xmlmodel.UpdateOn();
                            Task.Run((delegate
                            {
                                try
                                {
                                    convert.ConvertInnMassList(textboxfilemodel.Path, modelsnuone.SelectList.Listletter, modelsnuone.SelectColumnLetter.ColumnName, checkBoxModel.SelectIntRow,checkBoxModel.Colelementcollection, path);
                                    xmlmodel.AddXmlFile(path);
                                    xmlmodel.UpdateOff();
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }));
                        }
                        break;
                }
            }
        }
    }
}
