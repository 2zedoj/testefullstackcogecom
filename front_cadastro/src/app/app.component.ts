import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import {MatExpansionModule} from '@angular/material/expansion';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,
    MatExpansionModule
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  panelOpenState = false;
}
