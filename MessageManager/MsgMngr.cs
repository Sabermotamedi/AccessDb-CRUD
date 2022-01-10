using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entity;

namespace MessageManager
{
    public class MsgMngr
    {
        MsgBox ObjMsgBox = new MsgBox();


        static string MSG_FAEILD_LOGIN = " ورود شما موفقیت آمیز نبود ";
        static string MSG_SUCCESS_BACKUP = " فایل پشتیبان با موفیت تهیه شد";
        static string MSG_FAILED_BACKUP = " متاسفانه تهیه فایل پشتیبان با شکست روبرو شد ";
        static string MSG_DELETE_ALERT = " آیا از حذف این پرونده اطمینان دارید؟ ";
        static string MSG_SUCCESS_INSERT_DB = "آدرس مخزن داده با موفقیت ذخیره شد، برای اعمال تغییرات یک بار برنامه را ببندید و دوباره وارد شوید";
        static string MSG_FAILED_INSERT_DB = "متاسفانه اتصال با مخزن داده برقرار نشد، به راهنمای برنامه مراجعه کنید";

        static string CAPTION_FAEILD_LOGIN = "خطای ورود";
        static string CAPTION_SUCCESS_BACKUP = "فایل پشتبان";
        static string CAPTION_FAILED_BACKUP = "فایل پشتیبان";
        static string CAPTION_DELETE_ALERT = "حذف پرونده";
        static string CAPTION_SUCCESS_INSERT_DB = "اتصال به مخزن داده";
        static string CAPTION_FAILED_INSERT_DB = "اتصال ناموفق به مخزن داده";

        public MsgMngr() { }

        public DialogResult ShowMng(GeneralEnum.Msg State)
        {
            MessageSelector(State);
            return MessageBox.Show(ObjMsgBox.MsgState, ObjMsgBox.CaptionState, ObjMsgBox.MsgButtons,ObjMsgBox.MsgIcon);

        }

        public void ShowExection(string ex)
        {
            MessageBox.Show(ex);
        }

        private MsgBox MessageSelector(GeneralEnum.Msg State)
        {
            if (State == GeneralEnum.Msg.FailedLogin)
            {
                ObjMsgBox.CaptionState = CAPTION_FAEILD_LOGIN;
                ObjMsgBox.MsgState = MSG_FAEILD_LOGIN;
                ObjMsgBox.MsgButtons = MessageBoxButtons.OK;
                ObjMsgBox.MsgIcon = MessageBoxIcon.Stop;
                return ObjMsgBox;
            }
            else if (State == GeneralEnum.Msg.SuccesBackUp)
            {
                ObjMsgBox.CaptionState = CAPTION_SUCCESS_BACKUP;
                ObjMsgBox.MsgState = MSG_SUCCESS_BACKUP;
                ObjMsgBox.MsgButtons = MessageBoxButtons.OK;
                ObjMsgBox.MsgIcon = MessageBoxIcon.Information;

                return ObjMsgBox;
            }
            else if (State == GeneralEnum.Msg.FailedBackUp)
            {
                ObjMsgBox.CaptionState = CAPTION_FAILED_BACKUP;
                ObjMsgBox.MsgState = MSG_FAILED_BACKUP;
                ObjMsgBox.MsgButtons = MessageBoxButtons.RetryCancel;
                ObjMsgBox.MsgIcon = MessageBoxIcon.Error;

                return ObjMsgBox;
            }
            else if (State == GeneralEnum.Msg.DeleteAlert)
            {
                ObjMsgBox.CaptionState = CAPTION_DELETE_ALERT;
                ObjMsgBox.MsgState = MSG_DELETE_ALERT;
                ObjMsgBox.MsgButtons = MessageBoxButtons.YesNo;
                ObjMsgBox.MsgIcon = MessageBoxIcon.Question;

                return ObjMsgBox;
            }
            else if (State == GeneralEnum.Msg.SuccesInsertDataBase)
            {
                ObjMsgBox.CaptionState = CAPTION_SUCCESS_INSERT_DB;
                ObjMsgBox.MsgState = MSG_SUCCESS_INSERT_DB;
                ObjMsgBox.MsgButtons = MessageBoxButtons.OK;
                ObjMsgBox.MsgIcon = MessageBoxIcon.Information;

                return ObjMsgBox;
            }
            else if (State == GeneralEnum.Msg.FailedInsertDatabase)
            {
                ObjMsgBox.CaptionState = CAPTION_FAILED_INSERT_DB;
                ObjMsgBox.MsgState = MSG_FAILED_INSERT_DB;
                ObjMsgBox.MsgButtons = MessageBoxButtons.OK;
                ObjMsgBox.MsgIcon = MessageBoxIcon.Warning;

                return ObjMsgBox;
            }
            return ObjMsgBox;
        }


    }
}
