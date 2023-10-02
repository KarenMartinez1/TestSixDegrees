import { Component } from '@angular/core';
import { UserService } from './shared/services/user.service';
import { User } from './shared/Interfaces/user.interface';
import { take } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  users : User[]=[];
  constructor(private userService : UserService){}
  title = 'testApp';

  getUsers(){
    this.userService.getUsers()
   .pipe(take(1))
   .subscribe((res: any) =>{
    this.users= res;
  })
}
}
