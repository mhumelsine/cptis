import React from "react";

const LandingPage: React.FC = () => {
    const centerDiv: React.CSSProperties = {
        display: 'flex',
        flexDirection: 'column',
        alignItems: 'center',
        justifyContent: 'center',
        height: '80vh'
    };


    return (<React.Fragment> <div style={centerDiv} >
                <img src="./flhealthLogo.svg" width={"150px"} height={"150px"} />
                <h3>C P T I S</h3>
            </div>
    </React.Fragment>);
};

export default LandingPage;
