package org.alarmmanager;

import org.alarmmanager.external.EmailAlarm;

/**
 * Our company's alarm manager. This class is used by other internal software
 * to raise alarms. Currently, it alarms only via Email.
 * 
 */
public class AlarmManager {

    private final EmailAlarm emailAlarm = new EmailAlarm();

    public void raiseAlarm(String message) {
        emailAlarm.sendAlarmAsEmail(message);
    }
}
