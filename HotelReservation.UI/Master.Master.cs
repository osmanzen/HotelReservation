using HotelReservation.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelReservation.UI
{
    public partial class Master : System.Web.UI.MasterPage
    {
        MemberManagementBLL _memberManagement = new MemberManagementBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                pnlLogin.Controls.Clear();

                LinkButton lbUser = new LinkButton();
                lbUser.CssClass = "border-right-dark-4";
                lbUser.Text = "Hesabım";
                lbUser.Click += new EventHandler(btnUser_Click);
                lbUser.ValidationGroup = "";
                Panel1.Controls.Add(lbUser);


                LinkButton lbcikis = new LinkButton();
                lbcikis.CssClass = "border-right-dark-4";
                lbcikis.Text = "Çıkış";
                lbcikis.Click += new EventHandler(btnCikis_Click);
                pnlLogin.Controls.Add(lbcikis);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("index.aspx");
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("memberinfo.aspx");
        }



        protected void SubmitLogin_Click(object sender, EventArgs e)
        {
            string identity = txtLoginNo.Text;
            string password = txtLoginPassword.Text;

            if (identity != "" && password != "")
            {
                string memberID = _memberManagement.MemberID_Dondur(identity, password);

                if (memberID != "")
                {
                    Session["user"] = memberID;
                    Response.Redirect(Request.RawUrl);
                }
                else
                    Response.Write("<script>alert('Kimlik Numarası Yada Şifre Hatalı')</script>");

            }
            else
            {
                Response.Write("<script>alert('Kimlik Numarası Yada Şifre Boş Geçilemez.')</script>");
            }
        }

        protected void submitRegister_Click(object sender, EventArgs e)
        {
            string kimlikNo = txtRegNo.Text;
            string firstName = regFirst.Text;
            string lastName = regLast.Text;
            string email = regEmail.Text;
            string phone = regPhone.Text;
            string password = regPassword.Text;

            if (kimlikNo != "" && firstName != "" && lastName != "" && email != "" && phone != "" && password != "")
            {
                bool sonuc = _memberManagement.MemberEkle(kimlikNo, firstName, lastName, email, phone, password);

                if (sonuc)
                {
                    Response.Write("<script>alert('Kayıt Başarılı')</script>");
                    Response.Redirect(Request.RawUrl);
                }
                else
                {
                    Response.Write("<script>alert('Bu Kimlik Numarasıyla Daha Önce Hesap Açılmış.')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Form Boş Geçilemez.')</script>");
            }
        }
    }
}
