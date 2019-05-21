﻿using System;
using System.ComponentModel;
using System.Linq;

namespace YoungMomsAssistant.UI.Models {
    public class LifeEvent : ModelBase, IDataErrorInfo {
        private byte[] _image;
        private string _title;
        private string _summary;
        private DateTime? _date;

        public int Id { get; set; }

        public string Title {
            get => _title;
            set {
                _title = value;
                OnPropertyChanged();
            }
        }

        public string Summary {
            get => _summary;
            set {
                _summary = value;
                OnPropertyChanged();
            }
        }

        public DateTime? Date {
            get => _date;
            set {
                _date = value;
                OnPropertyChanged();
            }
        }

        public bool IsImageChanged { get; set; }

        public byte[] Image {
            get => _image;
            set {
                _image = value;
                IsImageChanged = true;
                OnPropertyChanged();
            }
        }

        public string Error => _errors.Values.FirstOrDefault(e => !string.IsNullOrWhiteSpace(e));

        public string this[string columnName] {
            get {
                var error = string.Empty;
                switch (columnName) {
                    case "Title":
                        if (string.IsNullOrWhiteSpace(Title) || Title.Length > 255) {
                            error = "error";
                            _errors["Title"] = error;
                        }
                        else {
                            _errors["Title"] = null;
                        }
                        break;
                    case "Summary":
                        if (Summary != null && Summary.Length > 1000) {
                            error = "error";
                            _errors["Summary"] = error;
                        }
                        else {
                            _errors["Summary"] = null;
                        }
                        break;
                    case "Image":
                        if (Image == null) {
                            error = "error";
                            _errors["Image"] = error;
                        }
                        else {
                            _errors["Image"] = null;
                        }
                        break;
                    case "Date":
                        if (Date == null || DateTime.Now.Date < Date.Value) {
                            error = "error";
                            _errors["Date"] = error;
                        }
                        else {
                            _errors["Date"] = null;
                        }
                        break;
                }

                return error;
            }
        }
    }
}
