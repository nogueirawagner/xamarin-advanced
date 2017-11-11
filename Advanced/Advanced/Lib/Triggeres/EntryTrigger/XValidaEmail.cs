using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace Advanced.Lib.EntryTrigger.Triggeres
{
  public class XValidaEmail : TriggerAction<Entry>
  {
    protected override void Invoke(Entry sender)
    {
      bool isEmail = Regex.IsMatch(sender.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
      if (!isEmail)
        sender.TextColor = Color.Red;
      else
        sender.TextColor = Color.Green;
    }
  }
}
