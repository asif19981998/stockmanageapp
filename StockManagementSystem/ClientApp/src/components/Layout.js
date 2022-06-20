import React, { Component } from 'react';
import { Container, Navbar } from 'reactstrap';

import { NavMenu } from './NavMenu';

export class Layout extends Component {
  static displayName = Layout.name;

  render () {
    return (
        <div>
            {/*<Counter />*/}
       <NavMenu> </NavMenu>
            <Container>
                {this.props.children}
            </Container>
      </div>
    );
  }
}
