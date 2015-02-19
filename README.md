# vision6.Net
Vision6.net is a full service .net api for http://www.vision6.com.au. See the readme below for examples on how to use it.

# Quick start

1) Add an AppSetting with your api key to your config (this is the easiest way)

    <appSettings>
    ...
       <add key="Vision6ApiKey" value="[your api key here]" />
    ...
    </appSettings>

2) In your app, change entities properties (Eg: Vision6Contact) as your list's fields, then call:

    var vision6ContactService = new Vision6ContactService();            
    var vision6Result = vision6ContactService.Add(listId, new List<Vision6Contact> {new Vision6Contact {Email = email, Mobile = mobile}}, true);
    if (!vision6Result.IsSuccess())
    {
        return new AjaxModel {Success = false, Message = vision6Result.ErrorObject().Description};
    }


