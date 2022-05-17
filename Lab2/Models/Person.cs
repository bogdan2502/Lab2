﻿    using System;


    namespace Lab2.Models
    {
        class Person
            {
               private static readonly string[] Horoscope = { "Aquarius", "Pisces", "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius", "Capricorn" };
               private static readonly string[] ChineseHoroscope = { "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat" };


                    #region Fields
                    private  string _name;
                    private  string _surname;
                    private  string _email;
                    private  DateTime _birthday;
                    private bool? _isAdult;
                    private bool? _isBirthday;
                    private string _sunSign;
                    private string _chineseSign;
                    #endregion


                  #region Properties
                  internal string Name
                    {
                        get { return _name; }
                        set { _name = value; }
                    }

                    internal string Surname
                        {
                            get { return _surname; }
                            set { _surname = value; }
                        }

                    internal string Email
                    {
                        get { return _email; }
                        set { _email = value; }
                    }

                  
                    internal DateTime BirthDate
                    {
                        get { return _birthday; }
                       set { _birthday = value; }
                    }
                   


            internal string SunSign
                    {
                        get { return _sunSign; }
                    }


                    internal string ChineseSign
                    {
                        get { return _chineseSign; }
                    }

                    internal bool? IsAdult
                    {
                        get { return _isAdult; }
                    }

                    internal bool? IsBirthday
                    {
                        get { return _isBirthday; }
                    }
            #endregion


            #region Methods
            internal string CalculateSunSign()
                    {
                        int d = _birthday.Day;
                        int m = _birthday.Month;

                        switch (m)
                        {
                            case 1:
                                return d < 20 ? _sunSign = Horoscope[Horoscope.Length - 1] : _sunSign = Horoscope[m - 1];
                                break;

                            case 2:
                               return d < 19 ? _sunSign = Horoscope[m - 2] : _sunSign = Horoscope[m - 1];
                               break;

                            case 3:
                            case 4: 
                            case 5:
                            case 6:
                                return d < 21 ? _sunSign = Horoscope[m - 2] : _sunSign = Horoscope[m - 1];
                                    break;

                            case 7:
                            case 8:
                            case 9:
                            case 10:
                                return d < 23 ? _sunSign = Horoscope[m - 2] : _sunSign = Horoscope[m - 1];
                                break;

                            default:
                                return d < 22 ? _sunSign = Horoscope[m - 2] : _sunSign = Horoscope[m - 1];
                        }
                    }

                    internal string CalculateChineseSign()
                    {
                        return _chineseSign = ChineseHoroscope[_birthday.Year % 12];
                    }


                    internal bool? CalculateIsAdult()
                    {
                          
                            return _isAdult = (((DateTime.Today.Year - _birthday.Year) >= 18) &&
                                    (DateTime.Today.Day >= _birthday.Day));
                        
                    }

                    internal bool? CalculateIsBirthday()
                    {
                         return  _isBirthday = ((DateTime.Today.Day == _birthday.Day) && (DateTime.Today.Month == _birthday.Month)); 
                    }
                    #endregion




            #region Constructors
            internal Person(string name, string surname, string email, DateTime birthDate)
                    {
                        _name = name;
                        _surname = surname;
                        _email = email;
                        _birthday = birthDate;
                    }


            internal Person(string name, string surname, string email) : this(name, surname, email, DateTime.Today)
            {
            }

            internal Person(string name, string surname, DateTime birthday) : this(name, surname, "Email is absent", birthday)
            {
            }

            internal Person()
            {

            }

            #endregion
        }
    }

