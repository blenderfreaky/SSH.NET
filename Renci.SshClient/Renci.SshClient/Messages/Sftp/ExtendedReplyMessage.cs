﻿
namespace Renci.SshClient.Messages.Sftp
{
    internal class ExtendedReplyMessage : SftpMessage
    {
        public override SftpMessageTypes SftpMessageType
        {
            get { return SftpMessageTypes.ExtendedReply; }
        }

        protected override void LoadData()
        {
            base.LoadData();
            //  TODO:   Load request specific reply
        }

        protected override void SaveData()
        {
            base.SaveData();
            //  TODO:   Save request specific reply
        }
    }
}