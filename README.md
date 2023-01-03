# Orion Plugin Template

Plugin template for Orion Plugins

## Reminders
Never change the namespace "OrionPlugin", and class name "Plugin".
Never change "RunPlugin". Function name needs to be named "RunPlugin" exactly in order for the plugin to function properly. You can add parameters of type string, int and char to the method.
If you want the plugin to be able to send embed to webhook, add "string webhook" as the last parameter.

## Usage

```cs
public static void RunPlugin(string s1, int i1, string asdf2, string webhook)
{
    //Code to execute, for example
    //Method1();
    //Clas2.Method2(s1);
    SendToWebhook(webhook, Resource1.jsonPayload);
}
```
