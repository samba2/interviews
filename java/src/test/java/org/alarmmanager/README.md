# Extend Alarm Manager

Our company uses the `AlarmManager` class a lot. It's basic (currently only supports email), 
but it did it job really well.

## Your Task
However, in this sprint we're tasked **add MS Teams support**. Internal users of the `AlarmManager` should be able 
to say *this AlarmManager goes via emails* or *this AlarmManager uses MS Teams*. It's enough to do this
configuration once on program startup. It's not necessary to change the alarm type during program runtime.

Once the `AlarmManager` is running, our internal users want to continue using the existing
`alarmManager.raiseAlarm(...)` method for raising alarms as they want to be flexible. When they decide to alarm via
a different type, they only want to change the configuration, not the rest of the code.

Note: Our PO mentioned that in one of the next sprints there will be also *Slack* and *Signal* support needed.

## The Alarms Are Already There
The good thing is that we can make use of the *Alarm* classes living in package `org.alarmmanager.external`. 
These classes contain all the technical details of email and MS Teams communication, and we don't need to care about it. 
However, as this code is provided to us by an external team, **we're not allowed to change it** 
(it will be a maven package in the future).

## Summary
- extend `AlarmManager` to also raise alarms via MS Teams
- ensure that our internal users can raise all alarms via the existing `alarmManager.raiseAlarm(...)` method
- don't touch the code in `org.alarmmanager.external`
- design for more alarm mechanisms to come
