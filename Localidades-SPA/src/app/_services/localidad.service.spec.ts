/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { LocalidadService } from './localidad.service';

describe('Service: Localidad', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [LocalidadService]
    });
  });

  it('should ...', inject([LocalidadService], (service: LocalidadService) => {
    expect(service).toBeTruthy();
  }));
});
