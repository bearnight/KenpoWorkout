using System;
using System.Collections;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Color = Xamarin.Forms.Color;

namespace KenpoWorkout.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Workout : ContentPage
    {
        bool From;
        bool Upto;
        private int value = 0;
        ArrayList Belts = new ArrayList();
        ArrayList nColor = new ArrayList();
        public readonly ArrayList BeltsLevels = new ArrayList();
        public readonly ArrayList BeltsDesc = new ArrayList();
        public readonly ArrayList NColorList = new ArrayList();
        private int slidersValue = 0;
        int result = 0;
        private bool _isTimerStart = true;


        public Workout()
        {

            LoadBeltsLevel();
            BackgroundColor = Color.FromHex((nColor[value].ToString()));
            InitializeComponent();
        }


        public void LoadBeltsLevel()
        {
            // Yellow
            BeltsLevels.Add("DELAYED SHIELD 5.0");
            BeltsLevels.Add("ALTERNATING FIST 5.0");
            BeltsLevels.Add("SHIELD OF DESTRUCTION 5.0");
            BeltsLevels.Add("DEFLECTING PENDULUM 5.0");
            BeltsLevels.Add("CAPTURED TWIGS 5.0");
            BeltsLevels.Add("LONE KIMONO 5.0");
            BeltsLevels.Add("OBSTRUCTING THE CLUB 5.0");
            BeltsLevels.Add("FIST OF AGGRESSION 5.0");
            BeltsLevels.Add("ATTACKING FIST 5.0");
            BeltsLevels.Add("SWORD AND HAMMER 5.0");

            //Orange
            BeltsLevels.Add("CLUTCHING FEATHERS 5.0");
            BeltsLevels.Add("TRIGGERED SALUTE 5.0");
            BeltsLevels.Add("GLANCING SALUTE 5.0");
            BeltsLevels.Add("BUCKLING BRANCH 5.0");
            BeltsLevels.Add("CRASHING WINGS 5.0");
            BeltsLevels.Add("GRIP OF THE SERPENT 5.0");
            BeltsLevels.Add("OBSCURE WING 5.0");
            BeltsLevels.Add("AGGRESSIVE TWINS 5.0");
            BeltsLevels.Add("REVERSING FIST 5.0");
            BeltsLevels.Add("SHIELD AND HAMMER 5.0");
            BeltsLevels.Add("FIVE SWORDS 5.0");
            BeltsLevels.Add("RAINING CLAW 5.0");
            BeltsLevels.Add("GLANCING WING 5.0");

            //Purple
            BeltsLevels.Add("TWIRLING WINGS 5.0");
            BeltsLevels.Add("LEAPING CRANE 5.0");
            BeltsLevels.Add("SWINGING PENDULUM 5.0");
            BeltsLevels.Add("STRIKING SERPENT'S HEAD 5.0");
            BeltsLevels.Add("EVADING THE CLUB 5.0");
            BeltsLevels.Add("CHECKING THE CLUB 5.0");
            BeltsLevels.Add("CROSSING TALON 5.0");
            BeltsLevels.Add("CHARGING MACE 5.0");
            BeltsLevels.Add("HAMMERING MACE 5.0");
            BeltsLevels.Add("RETURNING MACE 5.0");
            BeltsLevels.Add("HOOKING WINGS 5.0");
            BeltsLevels.Add("THRUSTING KNEE 5.0");
            BeltsLevels.Add("GLANCING WING 5.0");
            BeltsLevels.Add("OPPOSING CIRCLES 5.0");
            BeltsLevels.Add("COLLAPSING WEDGE 5.0");


            //Yellow Desc
            BeltsDesc.Add("(FRONT RIGHT HAND LAPEL GRAB)");
            BeltsDesc.Add("FRONT TWO HAND PUSH");
            BeltsDesc.Add("(FRONT STEP THROUGH LEFT ROUNDHOUSE PUNCH)");
            BeltsDesc.Add("(FRONT RIGHT FRONT THRUST KICK)");
            BeltsDesc.Add("(REAR BEAR HUG WITH ARMS PINNED)");
            BeltsDesc.Add("(FRONT LEFT HAND LAPEL GRAB)");
            BeltsDesc.Add("(FRONT RIGHT STP THROUGH OVERHEAD CLUB)");
            BeltsDesc.Add("(FRONT TWO HAND LAPEL GRAB - PULLING IN)");
            BeltsDesc.Add("(FRONT RIGHT STEP THROUGH STRAIGHT PUNCH)");
            BeltsDesc.Add("(RIGHT FLANK LEFT HAND SHOULDER GRAB)");

            //Orange Desc

            BeltsDesc.Add("(FRONT LEFT HAND, HAIR GRAB)");
            BeltsDesc.Add("FRONT RIGHT HAND DIRECT PUSH");
            BeltsDesc.Add("(FRONT RIGHT HAND CROSS PUSH)");
            BeltsDesc.Add("(FRONT LEFT STEP THROUGH BALL KICK)");
            BeltsDesc.Add("(REAR BEAR HUG ARMS FREE)");
            BeltsDesc.Add("(LEFT FLANK RIGHT ARM HEADLOCK)");
            BeltsDesc.Add("(LEFT HAND SHOULDER GRAB FROM RIGHT FLANK)");
            BeltsDesc.Add("(TWO HAND FRONT PUSH - RIGHT FOOT FORWARD");
            BeltsDesc.Add("(SHUFFLE LEFT JAB FROM LEFT FIGHTING STANCE)");
            BeltsDesc.Add("(SHUFFLE LEFT JAB FROM LEFT FIGHTING STANCE)");
            BeltsDesc.Add("(SHUFFLE LEFT JAB, RIGHT CROSS COMBO FROM LEFT FIGHTING STANCE)");
            BeltsDesc.Add("(SHUFFLE LEFT JAB, RIGHT UPPERCUT COMBO FROM LEFT FIGHTING STANCE)");
            BeltsDesc.Add(
                "(SHUFFLE LEFT JAB, RIGHT CROSS, LEFT UPPERCUT TO MID-SECTION COMBO FROM LEFT FIGHTING STANCE)");

            //Purple Desc
            BeltsDesc.Add("(REAR STIFF TWO HAND NECK OR SHOULDER GRAB)");
            BeltsDesc.Add("(FRONT RIGHT STEP THROUGH PUNCH)");
            BeltsDesc.Add("(FRONT RIGHT STEP-THROUGH ROUNDHOUSE KICK FROM LEFT FIGHTING STANCE)");
            BeltsDesc.Add("(FRONT BEAR HUG ARMS FREE)");
            BeltsDesc.Add("(FRONT RIGHT STEP THROUGH OVERHEAD CLUB)");
            BeltsDesc.Add("(FRONT RIGHT STEP THROUGH OVERHEAD CLUB)");
            BeltsDesc.Add("(FRONT RIGHT CROSS WRIST GRAB)");
            BeltsDesc.Add("(OFFENSIVE COMBINATION FROM A LEFT FIGHTING STANCE)");
            BeltsDesc.Add("(OFFENSIVE COMBINATION FROM A LEFT FIGHTING STANCE)");
            BeltsDesc.Add("(OFFENSIVE COMBINATION FROM A LEFT FIGHTING STANCE)");
            BeltsDesc.Add("(FRONT ATTEMPTED BODY LOCK TAKE DOWN)");
            BeltsDesc.Add("(FRONT ATTEMPTED BODY LOCK TAKE DOWN)");
            BeltsDesc.Add("(FRONT BODY LOCK ARMS FREE - HEAD RIGHT OF CENTER)");
            BeltsDesc.Add("(FRONT BODY LOCK ARMS FREE - HEAD LEFT OF CENTER)");

            //Yellow
            NColorList.Add("#FFFF00");
            NColorList.Add("#FFFF00");
            NColorList.Add("#FFFF00");
            NColorList.Add("#FFFF00");
            NColorList.Add("#FFFF00");
            NColorList.Add("#FFFF00");
            NColorList.Add("#FFFF00");
            NColorList.Add("#FFFF00");
            NColorList.Add("#FFFF00");
            //Orange
            NColorList.Add("#ffa500");
            NColorList.Add("#ffa500");
            NColorList.Add("#ffa500");
            NColorList.Add("#ffa500");
            NColorList.Add("#ffa500");
            NColorList.Add("#ffa500");
            NColorList.Add("#ffa500");
            NColorList.Add("#ffa500");
            NColorList.Add("#ffa500");
            NColorList.Add("#ffa500");
            NColorList.Add("#ffa500");
            NColorList.Add("#ffa500");
            //Purple
            NColorList.Add("#6a0dad");
            NColorList.Add("#6a0dad");
            NColorList.Add("#6a0dad");
            NColorList.Add("#6a0dad");
            NColorList.Add("#6a0dad");
            NColorList.Add("#6a0dad");
            NColorList.Add("#6a0dad");
            NColorList.Add("#6a0dad");
            NColorList.Add("#6a0dad");
            NColorList.Add("#6a0dad");
            NColorList.Add("#6a0dad");
            NColorList.Add("#6a0dad");
            NColorList.Add("#6a0dad");
            NColorList.Add("#6a0dad");
            // Belt Level
            Belts.Add("Yellow");
            Belts.Add("Orange");
            Belts.Add("Purple");
            // BeltColors
            nColor.Add("#FFFF00");
            nColor.Add("#ffa500");
            nColor.Add("#6a0dad");

        }


        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {

            value = (int)args.NewValue;

            Sliders.BackgroundColor = Color.FromHex(nColor[value].ToString());
            BackgroundColor = Color.FromHex((nColor[value].ToString()));
            rotatingLabel.Text = $"Belt Level: {Belts[value]}";
        }

        async void BtnStart_OnClicked(object sender, EventArgs e)
        {
            Sliders.IsVisible = false;
            btnUpTo.IsVisible = false;
            btnFrom.IsVisible = false;
            btnStart.IsVisible = false;
            BeltDesc.IsVisible = true;
            btnStop.IsVisible = true;
            slidersValue = (int)Sliders.Value;
            _isTimerStart = true;
            if (From == false && Upto == true)
            {
                switch ((slidersValue + 1))
                {
                    case 1:
                        result = new Random().Next(0, 9);
                        break;
                    case 2:

                        result = new Random().Next(0, 21);
                        break;
                    case 3:

                        result = new Random().Next(0, 34);
                        break;
                    default:
                        DoNothing();
                        break;
                }

                BackgroundColor = Color.FromHex(NColorList[result].ToString());
                rotatingLabel.Text = $"{BeltsLevels[result]}";
                BeltDesc.Text = $"{BeltsDesc[result]}";
                StartTimer();
            }
            else
            {
                switch ((slidersValue + 1))
                {
                    case 1:
                        result = new Random().Next(0, 34);
                        break;
                    case 2:
                        result = new Random().Next(10, 34);
                        break;
                    case 3:
                        result = new Random().Next(22, 34);
                        break;
                    default:
                        DoNothing();
                        break;
                }

                BackgroundColor = Color.FromHex(NColorList[result].ToString());
                rotatingLabel.Text = $"{BeltsLevels[result]}";
                BeltDesc.Text = $"{BeltsDesc[result]}";
                StartTimerFrom();
            }
        }

        public void StartTimerFrom()
        {
            try
            {

                Device.StartTimer(TimeSpan.FromSeconds(25), () =>
                {
                    if (From == true && Upto == false)
                    {
                        switch ((slidersValue + 1))
                        {
                            case 1:
                                result = new Random().Next(0, 34);
                                break;
                            case 2:

                                result = new Random().Next(10, 34);
                                break;
                            case 3:

                                result = new Random().Next(22, 34);
                                break;
                            default:
                                DoNothing();
                                break;
                        }
                    }

                    BackgroundColor = Color.FromHex(NColorList[result].ToString());
                    rotatingLabel.Text = $"{BeltsLevels[result]}";
                    BeltDesc.Text = $"{BeltsDesc[result]}";
                    if (_isTimerStart == false)
                    {
                        BackgroundColor = Color.FromHex((nColor[value].ToString()));
                        rotatingLabel.Text = $"Belt Level: {Belts[value]}";
                        Stop();


                    }
                    return _isTimerStart;
                });
            }
            catch (Exception e)
            {
                _isTimerStart = true;
                StartTimerFrom();
                var sete = e.ToString();
            }
        }

        public void StartTimer()
        {
            try
            {
                Device.StartTimer(TimeSpan.FromSeconds(25), () =>
                {
                    if (From == false && Upto == true)
                    {
                        switch ((slidersValue + 1))
                        {
                            case 1:
                                result = new Random().Next(0, 9);
                                break;
                            case 2:

                                result = new Random().Next(0, 21);
                                break;
                            case 3:

                                result = new Random().Next(0, 34);
                                break;
                            default:
                                DoNothing();
                                break;
                        }
                    }

                    BackgroundColor = Color.FromHex(NColorList[result].ToString());
                    rotatingLabel.Text = string.Format("{0}", BeltsLevels[result]);
                    BeltDesc.Text = String.Format("{0}", BeltsDesc[result]);

                    if (_isTimerStart == false)
                    {
                        BackgroundColor = Color.FromHex((nColor[value].ToString()));
                        rotatingLabel.Text = $"Belt Level: {Belts[value]}";
                        Stop();


                    }
                    return _isTimerStart;
                });

            }
            catch (Exception e)
            {
                _isTimerStart = true;
                StartTimer();
                var sete = e.ToString();
            }
        }

        void DoNothing()
        {
        }

        private void BtnUpTo_OnClicked(object sender, EventArgs e)
        {
            Upto = true;
            From = false;
            if (Upto == true)
            {
                _isTimerStart = true;
                btnUpTo.Focus();
                btnUpTo.BackgroundColor = Color.Aqua;
                btnFrom.Unfocus();
            }
        }

        private void BtnFrom_OnClicked(object sender, EventArgs e)
        {
            Upto = false;
            From = true;
            if (From == true)
            {
                _isTimerStart = true;
                btnUpTo.Unfocus();
                btnFrom.BackgroundColor = Color.Aqua;
                btnFrom.Focus();
            }
        }

        private void BtnStop_OnClicked(object sender, EventArgs e)
        {
            _isTimerStart = false;
            Stop();
            BackgroundColor = Color.FromHex((nColor[value].ToString()));
            rotatingLabel.Text = $"Belt Level: {Belts[value]}";

        }

        private void Stop()
        {
            Sliders.IsVisible = true;
            btnUpTo.IsVisible = true;
            btnFrom.IsVisible = true;
            btnStart.IsVisible = true;
            BeltDesc.IsVisible = false;
            btnStop.IsVisible = false;
            BackgroundColor = Color.FromHex((nColor[value].ToString()));

        }
    }
}