using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZineClient.Migrations
{
    public partial class AllPostsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "Published",
                value: new DateTime(2020, 4, 8, 15, 22, 37, 650, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "ApplicationUserId", "Body", "MainImageFile", "MainImageUrl", "Published", "Source", "Title" },
                values: new object[,]
                {
                    { 8, null, "I haven’t laughed so hard in weeks... not even all the memes can beat this. I was standing there laughing and he even came out to say hello! Thank you Psychic Barber!!", null, "https://scontent-sea1-1.xx.fbcdn.net/v/t1.0-9/92678252_10158280722022417_8621941719081943040_n.jpg?_nc_cat=101&_nc_sid=ca434c&_nc_oc=AQmidwsOmbAFIvfNQ5Jy5uNfaNXM6HDM57L2Q8iM5-_zt2Xf06xvibM86Uxe1PwJzDYPjRb3pYGWXy0Jwe2gdlIp&_nc_ht=scontent-sea1-1.xx&oh=64aa052c2c292b33fbf25e5c0875ed43&oe=5EB3027C", new DateTime(2020, 4, 8, 15, 22, 37, 650, DateTimeKind.Local).AddTicks(3231), "West Seattle Connection", "Psychic Barber" },
                    { 7, null, "I saw this person on a high rise bicycle coming down Highland Park Way today. It’s always fun to see people doing interesting things like this, not to mention the skill of using a bus stop sign to hold yourself on a hill! EDIT: one of the commenters identified this person as Aaron from Aaron's Bicycle Repair in White Center. The website lists his shop as open. If you are in need of such services, be sure to keep his business in mind.", null, "https://scontent-sea1-1.xx.fbcdn.net/v/t1.0-9/91850808_10218951980923965_7620497844079689728_n.jpg?_nc_cat=111&_nc_sid=ca434c&_nc_oc=AQnF1Hi8Gp2zOzX3mslL2f7Ni4toCHkAcbL0tuoHqy3DQ_cKgjnZeod8vZMKhSOgTe1Qbw-M-ZT_zoYu2wX8l7rx&_nc_ht=scontent-sea1-1.xx&oh=ab0167a841a066036d87af341e27f5c8&oe=5EB32C1C", new DateTime(2020, 4, 8, 15, 22, 37, 650, DateTimeKind.Local).AddTicks(3223), "West Seattle Connection", "Bicycle Person" },
                    { 6, null, "Anyone on here that used to go to the Party House in White Center, sad to say that my Dad, Hurley Ring has passed away at the age of 94. He owned and ran the Party House for 36 years from 1952 to 1988. He loved his time running the store and meeting so many people, many of whom became good friends! He had a great run! Thanks to all of you who made it memorable for him!", null, "https://scontent-sea1-1.xx.fbcdn.net/v/t1.0-9/92122080_3663086160399133_3531716169725640704_n.jpg?_nc_cat=108&_nc_sid=07e735&_nc_oc=AQl8p8W4In9MyKp78AZFWqbw9xOcEwKREc_6h852TyfizBZ3hUytBT0Ry8hKUqd4Ly6n9unf_2mFdwxHf9kVSY91&_nc_ht=scontent-sea1-1.xx&oh=5f2b1e72c1e7395fa239ec80d8529160&oe=5EB2EBC9", new DateTime(2020, 4, 8, 15, 22, 37, 650, DateTimeKind.Local).AddTicks(3215), "West Seattle Connection", "Party House" },
                    { 9, null, "Given the state of the West Seattle Bridge does anyone else think we should be revisiting the decision not to tunnel under the Duwamish for our light rail? Perhaps a tunnel for both traffic and light rail might make the project more cost effective given the cost we’re currently facing to repair a crumbling bridge, and building another huge bridge for light rail, and with the economic costs of having the bridge out of commission for an unknown period of time? *pic taken June 2019. My Son and I noticed them working on the bridge cracks throughout 2019", null, "https://scontent-sea1-1.xx.fbcdn.net/v/t1.0-9/92531837_10221747110850778_7079577568193544192_n.jpg?_nc_cat=103&_nc_sid=ca434c&_nc_oc=AQnJfUCl5n_sEO61IK8JF1RsYkYdHURtBNbUrjd7PQig0PS7FYpF0A3r_2TK7ZrlGx2Dpg0NfOTiB_0Di6y1plYc&_nc_ht=scontent-sea1-1.xx&oh=041d6eb8b2b6608b92bea2c1515d80d8&oe=5EB3DD39", new DateTime(2020, 4, 8, 15, 22, 37, 650, DateTimeKind.Local).AddTicks(3238), "West Seattle Connection", "Our Bridge" },
                    { 4, null, "Rebecca Dinerstein Knight's strange and delightful second novel, Hex, opens with its protagonist in crisis. Nell Barber is an ex-doctoral student at Columbia; her lab, which studied toxins, has been disbanded after a student accidentally poisons herself, and now Nell is floating through New York, grief-stricken and in need of work. She's also profoundly lovesick for her dissertation advisor, a magnetic young botanist named Dr. Joan Kallas. Without Joan's 'absolutely necessary nearness,' Nell is undone. She describes herself as 'deleted.' She spends her time cooking up ways to continue her research without a lab; writing long letters to Joan in composition notebooks; and seeking beauty wherever she can find it.", null, "https://media.npr.org/assets/bakertaylor/covers/h/hex/9781984877376_custom-d7f85cab68b5281986f54966f07ac251b2432495-s300-c85.jpg", new DateTime(2020, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.npr.org/2020/04/04/826891969/charming-hex-insists-on-beauty-and-joy", "Charming 'Hex' Insists On Beauty And Joy" },
                    { 3, null, "The Russian poet Joseph Brodsky once said that prison is a lack of space counterbalanced by a surplus of time. Our current lockdown can't be compared to being locked up, but with so much surplus time on our hands, many of us are eager for stories that will help us escape endless thoughts of COVID-19. Here are three that did that for me: Unorthodox This desire for escape underlies the appeal of Unorthodox, the four-part Netflix series that has viewers whooshing through it in a single night. Loosely based on a memoir by Deborah Feldman, it stars Israeli actor Shira Haas as 19-year-old Esther 'Esty' Shapiro, a woman who flees her marriage and her tight Hasidic community in Williamsburg, Brooklyn. Esty jets off to Berlin, where a group of music students take her under their wing. Meanwhile, she's pursued by her husband, Yanky (Amit Rahav), and his cousin Moishe (Jeff Wilbusch), who's something of a thug.", null, "https://media.npr.org/assets/img/2020/04/06/anika-molnar-netflix_wide-37dbf151aa711845cd3336cdacf929c135f1d46b-s800-c85.jpg", new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.npr.org/2020/04/06/828085961/need-an-escape-try-unorthodox-baghdad-central-and-abigail", "Need An Escape? Try 'Unorthodox,' 'Baghdad Central' And 'Abigail'" },
                    { 2, null, "'This story begins with the Adderall,' opens Casey Schwartz's Attention: A Love Story. In 2000, Schwartz was in college, struggling to write an essay, when a friend offered her a pill 'the deep bright blue of a cartoon sky' and her hand 'shot out to receive it.'Here already are the seeds of what is coming: It is not 'Adderall' but 'the Adderall,' not the serviceable 'take' or 'grab' but the sacramental 'receive.'Schwartz fell in love. Adderall was 'attention weaponized, slashing through procrastination and self-doubt, returning me to a place that felt almost like childhood, with its unclouded pleasures of rapt hours, lost in books and imagination. Childhood, but with a jittery amphetamine edge...'", null, "https://media.npr.org/assets/bakertaylor/covers/a/attention/9781524747107_custom-5554b06219ed55f1cabc3e970c2bb37de6a89840-s300-c85.jpg", new DateTime(2020, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.npr.org/2020/04/08/828800691/in-an-age-of-screens-looking-for-attention-in-all-the-wrong-places", "In An Age Of Screens, Looking For 'Attention' In All The Wrong Places" },
                    { 5, null, "Here's the West Seattle Bridge on Sept. 19, 2015. See any cracks? Nope. Photo by Patrick Robinson.", null, "https://scontent-sea1-1.xx.fbcdn.net/v/t1.0-9/s960x960/92598824_10222383695444196_8978529166924185600_o.jpg?_nc_cat=105&_nc_sid=ca434c&_nc_oc=AQkbCoY2oCStEgnkHqeWuosOfw0dvbp3s3chQk5rzZ4Fzju5FzY5JwWcRndOnNy8PFbcv0AsljHNVgA1igwYzzhI&_nc_ht=scontent-sea1-1.xx&_nc_tp=7&oh=750b576c6a65f531de6ea44952a0b945&oe=5EB40642", new DateTime(2020, 4, 8, 15, 22, 37, 650, DateTimeKind.Local).AddTicks(3189), "West Seattle Connection", "Bridge now" }
                });

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 22, 37, 642, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 2,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 22, 37, 648, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 3,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 22, 37, 648, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 4,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 22, 37, 648, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 5,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 22, 37, 648, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 6,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 22, 37, 648, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 7,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 22, 37, 648, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 8,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 22, 37, 648, DateTimeKind.Local).AddTicks(7757));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "Published",
                value: new DateTime(2020, 4, 8, 15, 21, 8, 109, DateTimeKind.Local).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 21, 8, 101, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 2,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 21, 8, 107, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 3,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 21, 8, 107, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 4,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 21, 8, 107, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 5,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 21, 8, 107, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 6,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 21, 8, 107, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 7,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 21, 8, 107, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 8,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 21, 8, 107, DateTimeKind.Local).AddTicks(9963));
        }
    }
}
