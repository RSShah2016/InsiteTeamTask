import { Http, Response, Headers, RequestOptions, URLSearchParams } from '@angular/http';
import { Attendance } from '../models/Attendance.class';

export class AttendanceService {
    Attendance: Attendance[];
    constructor(
        private _http: Http
    ) 
    {
        
    }

    GetAttendance()
    {
        
    }
}