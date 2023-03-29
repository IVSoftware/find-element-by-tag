using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace find_element_by_tag
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            buttonTest.Click += onClickTest;
        }

        private void onClickTest(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Root));
            using (StringReader reader = new StringReader(mockSource))
            {
                Root root = (Root)serializer.Deserialize(reader);

                var listDayOfWeek = root
                    .GetFixtureByRaceResponse
                    .RacingEvent
                    .Meeting
                    .MeetingInfo
                    .DayOfWeek;

                foreach (var dayOfWeekElement in listDayOfWeek)
                {
                    try
                    {
                        switch (dayOfWeekElement.Lang)
                        {
                            case "en-us":
                                textBox1.Text = dayOfWeekElement.Text;
                                break;
                            case "zh-cn":
                                textBox2.Text = dayOfWeekElement.Text;
                                break;
                            case "zh-hk":
                                textBox3.Text = dayOfWeekElement.Text;
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.Assert(false, ex.Message);
                    }
                }
            }
        }

        private void onClickTestOLD(object sender, EventArgs e)
        {
            // Load from file, or for testing purposes parse the mock source
            // XElement xel = XElement.Load(fileName);
            XElement xel = XElement.Parse(mockSource);

            // See this answer for working with namespaces:
            // https://stackoverflow.com/a/4288440/5438626
            XNamespace ns2 = XNamespace.Get("http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2");

            var langDayOfWeek =
                xel
                .Descendants(ns2 + "DayOfWeek");
            foreach (var dayOfWeekElement in langDayOfWeek)
            {
                try
                {
                    switch (dayOfWeekElement.Attribute("lang").Value)
                    {
                        case "en-us":
                            textBox1.Text = (string)dayOfWeekElement;
                            break;
                        case "zh-cn":
                            textBox2.Text = (string)dayOfWeekElement;
                            break;
                        case "zh-hk":
                            textBox3.Text = (string)dayOfWeekElement;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Debug.Assert(false, ex.Message);
                }
            }
        }
    const string mockSource = @"
<Root>
   <ns2:GetFixtureByRaceResponse xmlns:ns2=""http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2"" xmlns=""http://www.hkjc.org.hk/Schema/CAP/Common_v2"">
      <ns2:Return>
         <Code>0</Code>
         <EndOf_v2_0Elm />
      </ns2:Return>
      <ns2:RacingEvent>
         <ns2:Meeting meetingDate=""2022-09-11+08:00"" meetingID=""MTG_20220911_0001"" statusLastUpdated=""2022-09-07T14:22:17.000+08:00"" venueCode=""ST"">
            <ns2:MeetingInfo>
               <ns2:DayOfWeek lang=""en-us"">SUN</ns2:DayOfWeek>
               <ns2:DayOfWeek lang=""zh-cn"">星期日</ns2:DayOfWeek>
               <ns2:DayOfWeek lang=""zh-hk"">星期日</ns2:DayOfWeek>
               <ns2:Status>Defined</ns2:Status>
               <ns2:RaceSeason>22/23</ns2:RaceSeason>
               <ns2:NumOfRace>10</ns2:NumOfRace>
               <ns2:MeetingNo>01</ns2:MeetingNo>
               <ns2:TrackCode>TURF</ns2:TrackCode>
               <ns2:MeetingType>D</ns2:MeetingType>
               <ns2:ScheduledNumOfRace>10</ns2:ScheduledNumOfRace>
               <ns2:ActualNumOfRace>0</ns2:ActualNumOfRace>
               <ns2:EndOf_v2_0Elm />
            </ns2:MeetingInfo>
            <ns2:EndOf_v2_0Elm />
         </ns2:Meeting>
         <ns2:Race meetingID=""MTG_20220911_0001"" raceID=""RACE_20220911_0010"" raceNo=""1"" statusLastUpdated=""2022-09-07T09:06:53.522+08:00"">
            <ns2:RaceInfo>
                <ns2:Status>Declared</ns2:Status>
                <ns2:PostTime>2022-09-11T13:00:00.000+08:00</ns2:PostTime>
                <ns2:RaceName lang=""en-us"" seqNo=""1"">MOUNT PARKER HANDICAP</ns2:RaceName>
                <ns2:RaceName lang=""zh-cn"" seqNo=""1"">柏架山让赛</ns2:RaceName>
                <ns2:RaceName lang=""zh-hk"" seqNo=""1"">柏架山讓賽</ns2:RaceName>
                <ns2:Distance>1600</ns2:Distance>
                <ns2:NoOfDeclaredStarters>14</ns2:NoOfDeclaredStarters>
                <ns2:PrizeMoney prizeLevel=""1"">461700.00</ns2:PrizeMoney>
                <ns2:PrizeMoney prizeLevel=""2"">178200.00</ns2:PrizeMoney>
                <ns2:PrizeMoney prizeLevel=""3"">93150.00</ns2:PrizeMoney>
                <ns2:PrizeMoney prizeLevel=""4"">48600.00</ns2:PrizeMoney>
                <ns2:PrizeMoney prizeLevel=""5"">28350.00</ns2:PrizeMoney>
                <ns2:PrizeMoney prizeLevel=""6"">0.00</ns2:PrizeMoney>
                <ns2:PrizeMoney prizeLevel=""7"">0.00</ns2:PrizeMoney>
                <ns2:PrizeMoney prizeLevel=""8"">0.00</ns2:PrizeMoney>
                <ns2:PrizeMoney prizeLevel=""9"">0.00</ns2:PrizeMoney>
                <ns2:StakePrize>810000.00000</ns2:StakePrize>
                <ns2:RaceRemarks lang=""en-us"" seqNo=""1"" />
                <ns2:RaceRemarks lang=""en-us"" seqNo=""2"" />
                <ns2:RaceRemarks lang=""en-us"" seqNo=""3"" />
                <ns2:RaceRemarks lang=""en-us"" seqNo=""4"" />
                <ns2:RaceRemarks lang=""en-us"" seqNo=""5"" />
                <ns2:RaceRemarks lang=""en-us"" seqNo=""6"" />
                <ns2:RaceRemarks lang=""en-us"" seqNo=""7"" />
                <ns2:RaceRemarks lang=""en-us"" seqNo=""8"" />
                <ns2:RaceRemarks lang=""zh-cn"" seqNo=""1"" />
                <ns2:RaceRemarks lang=""zh-cn"" seqNo=""2"" />
                <ns2:RaceRemarks lang=""zh-cn"" seqNo=""3"" />
                <ns2:RaceRemarks lang=""zh-cn"" seqNo=""4"" />
                <ns2:RaceRemarks lang=""zh-cn"" seqNo=""5"" />
                <ns2:RaceRemarks lang=""zh-cn"" seqNo=""6"" />
                <ns2:RaceRemarks lang=""zh-cn"" seqNo=""7"" />
                <ns2:RaceRemarks lang=""zh-cn"" seqNo=""8"" />
                <ns2:RaceRemarks lang=""zh-hk"" seqNo=""1"" />
                <ns2:RaceRemarks lang=""zh-hk"" seqNo=""2"" />
                <ns2:RaceRemarks lang=""zh-hk"" seqNo=""3"" />
                <ns2:RaceRemarks lang=""zh-hk"" seqNo=""4"" />
                <ns2:RaceRemarks lang=""zh-hk"" seqNo=""5"" />
                <ns2:RaceRemarks lang=""zh-hk"" seqNo=""6"" />
                <ns2:RaceRemarks lang=""zh-hk"" seqNo=""7"" />
                <ns2:RaceRemarks lang=""zh-hk"" seqNo=""8"" />
                <ns2:Local>
                    <ns2:RaceIndex>1</ns2:RaceIndex>
                    <ns2:ClassCode>5</ns2:ClassCode>
                    <ns2:TrackCode>TURF</ns2:TrackCode>
                    <ns2:CourseCode>A</ns2:CourseCode>
                    <ns2:RatingRange>040-000</ns2:RatingRange>
                    <ns2:RatingType>H</ns2:RatingType>
                    <ns2:RaceType>H</ns2:RaceType>
                    <ns2:FieldSize>14</ns2:FieldSize>
                    <ns2:CupIndex />
                    <ns2:Footnotes lang=""en-us"" seqNo=""1"" />
                    <ns2:Footnotes lang=""en-us"" seqNo=""2"" />
                    <ns2:Footnotes lang=""en-us"" seqNo=""3"" />
                    <ns2:Footnotes lang=""en-us"" seqNo=""4"" />
                    <ns2:Footnotes lang=""zh-hk"" seqNo=""1"" />
                    <ns2:Footnotes lang=""zh-hk"" seqNo=""2"" />
                    <ns2:Footnotes lang=""zh-hk"" seqNo=""3"" />
                    <ns2:Footnotes lang=""zh-hk"" seqNo=""4"" />
                    <ns2:InternationalRaceIndicator>0</ns2:InternationalRaceIndicator>
                    <ns2:SectionNo>1</ns2:SectionNo>
                    <ns2:Going />
                    <ns2:SpecialRaceIndicator />
                    <ns2:SecDivDisplayIndicator>S</ns2:SecDivDisplayIndicator>
                    <ns2:StarterRemarks lang=""en-us"" seqNo=""1"" />
                    <ns2:StarterRemarks lang=""en-us"" seqNo=""2"" />
                    <ns2:StarterRemarks lang=""en-us"" seqNo=""3"" />
                    <ns2:StarterRemarks lang=""en-us"" seqNo=""4"" />
                    <ns2:StarterRemarks lang=""en-us"" seqNo=""5"" />
                    <ns2:StarterRemarks lang=""en-us"" seqNo=""6"" />
                    <ns2:StarterRemarks lang=""en-us"" seqNo=""7"" />
                    <ns2:StarterRemarks lang=""en-us"" seqNo=""8"" />
                    <ns2:StarterRemarks lang=""zh-cn"" seqNo=""1"" />
                    <ns2:StarterRemarks lang=""zh-cn"" seqNo=""2"" />
                    <ns2:StarterRemarks lang=""zh-cn"" seqNo=""3"" />
                    <ns2:StarterRemarks lang=""zh-cn"" seqNo=""4"" />
                    <ns2:StarterRemarks lang=""zh-cn"" seqNo=""5"" />
                    <ns2:StarterRemarks lang=""zh-cn"" seqNo=""6"" />
                    <ns2:StarterRemarks lang=""zh-cn"" seqNo=""7"" />
                    <ns2:StarterRemarks lang=""zh-cn"" seqNo=""8"" />
                    <ns2:StarterRemarks lang=""zh-hk"" seqNo=""1"" />
                    <ns2:StarterRemarks lang=""zh-hk"" seqNo=""2"" />
                    <ns2:StarterRemarks lang=""zh-hk"" seqNo=""3"" />
                    <ns2:StarterRemarks lang=""zh-hk"" seqNo=""4"" />
                    <ns2:StarterRemarks lang=""zh-hk"" seqNo=""5"" />
                    <ns2:StarterRemarks lang=""zh-hk"" seqNo=""6"" />
                    <ns2:StarterRemarks lang=""zh-hk"" seqNo=""7"" />
                    <ns2:StarterRemarks lang=""zh-hk"" seqNo=""8"" />
                    <ns2:EndOf_v2_0Elm />
                </ns2:Local>
                <ns2:WageringFieldSize>14</ns2:WageringFieldSize>
                <ns2:EndOf_v2_0Elm />
                </ns2:RaceInfo>
            <ns2:EndOf_v2_0Elm />
         </ns2:Race>
		</ns2:RacingEvent>
    </ns2:GetFixtureByRaceResponse>
</Root>
";
    }
}
